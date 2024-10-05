using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using RawExportApiClient.Abstractions;
using RawExportApiClient.Commands;
using RawExportApiClient.Interfaces;

namespace RawExportApiClient.Helpers;

public sealed class ApiClient : DisposableWrapperBase
{
    protected override bool IsDisposed { get; set; }

    private readonly ILogger _logger;
    private readonly HttpClient _client;
    private readonly AuthorizationProvider _authorizationProvider;

    public ApiClient(
        ILogger logger,
        HttpClient client,
        int userId,
        string secretKey)
    {
        _logger = logger;
        _client = client;
        _authorizationProvider = new AuthorizationProvider(secretKey, userId);
    }

    private void AddAuthorizationHeader(Uri url, HttpMethod httpMethod, Guid requestId)
    {
        const string headerName = "Authorization";
        var headerValue = _authorizationProvider.CreateAuthorizationHeader(httpMethod, url);
        _logger.Info("Authorization created [RequestId: {RequestId}; Authorization: {Authorization}]", requestId,
            headerValue);

        _client.DefaultRequestHeaders.Remove(headerName);
        _client.DefaultRequestHeaders.Add(headerName, headerValue);
    }

    public async Task<TResult> PostAsync<TResult>(RequestBase request)
    {
        var requestId = Guid.NewGuid();
        var url = UrlProvider.BuildUrl(_client.BaseAddress, request.Path, request.GetQuery());
        AddAuthorizationHeader(url, HttpMethod.Post, requestId);

        var response = await _client.PostAsync(url.PathAndQuery, null);
        _logger.Info("[{RequestId}] POST: {Url} Status Code: {Status}\n{Body}",
            requestId,
            url,
            response.StatusCode,
            await response.Content.ReadAsStringAsync());

        return await response.Content.Deserialize<TResult>();
    }

    public async Task<TResult> GetAsync<TResult>(RequestBase request)
    {
        var requestId = Guid.NewGuid();
        var url = UrlProvider.BuildUrl(_client.BaseAddress, request.Path, request.GetQuery());
        AddAuthorizationHeader(url, HttpMethod.Get, requestId);

        var response = await _client.GetAsync(url.PathAndQuery);
        _logger.Info("[{RequestId}] GET: {Url} Status Code: {Status}\n{Body}",
            requestId,
            url,
            response.StatusCode,
            await response.Content.ReadAsStringAsync());

        return await response.Content.Deserialize<TResult>();
    }

    public async Task<Stream> GetStreamAsync(FileRequestBase request)
    {
        _logger.Info("GET file: {Url}", request.Path);
        return await _client.GetStreamAsync(request.Path);
    }


    protected override void Dispose(bool disposing)
    {
        if (IsDisposed)
        {
            return;
        }

        if (disposing)
        {
            _client?.Dispose();
            _authorizationProvider?.Dispose();
        }

        IsDisposed = true;
    }

    public override void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public override ValueTask DisposeAsync()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
        return new ValueTask();
    }
}