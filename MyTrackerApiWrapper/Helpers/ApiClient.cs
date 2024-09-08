using System;
using System.Net.Http;
using System.Threading.Tasks;
using MyTrackerApiWrapper.ExportAPI.RawData;

namespace MyTrackerApiWrapper.Helpers;

public sealed class ApiClient
{
    private readonly HttpClient _client;
    private readonly AuthorizationProvider _authorizationProvider;
    
    public ApiClient(HttpClient client, int userId, string secretKey)
    {
        _client = client;
        _authorizationProvider = new AuthorizationProvider(secretKey, userId);
    }

    private void AddAuthorizationHeader(Uri url, HttpMethod httpMethod)
    {
        const string headerName = "Authorization";
        var headerValue = _authorizationProvider.CreateAuthorizationHeader(httpMethod, url);
        
        _client.DefaultRequestHeaders.Remove(headerName);
        _client.DefaultRequestHeaders.Add(headerName, headerValue); 
    }

    public async Task<TResult> PostAsync<TResult>(RequestBase request)
    {
        var url = UrlProvider.BuildUrl(_client.BaseAddress, request.Path, request.GetQuery());
        AddAuthorizationHeader(url, HttpMethod.Post);

        var response = await _client.PostAsync(url.PathAndQuery, null);
        return await response.Content.Deserialize<TResult>();
    }

    public async Task<TResult> GetAsync<TResult>(RequestBase request)
    {
        var url = UrlProvider.BuildUrl(_client.BaseAddress, request.Path, request.GetQuery());
        AddAuthorizationHeader(url, HttpMethod.Get);

        var response = await _client.GetAsync(url.PathAndQuery);
        return await response.Content.Deserialize<TResult>();
    }
}