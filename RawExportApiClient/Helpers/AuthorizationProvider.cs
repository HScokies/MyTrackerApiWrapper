using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RawExportApiClient.Abstractions;

namespace RawExportApiClient.Helpers;

internal sealed class AuthorizationProvider : DisposableWrapperBase
{
    protected override bool IsDisposed { get; set; }
    private readonly int _userId;
    private readonly HMACSHA1 _sha1;

    public AuthorizationProvider(string hashKey, int userId) : this(Encoding.UTF8.GetBytes(hashKey), userId)
    {
    }

    public AuthorizationProvider(byte[] hashKey, int userId)
    {
        _userId = userId;
        _sha1 = new HMACSHA1(hashKey);
    }

    public string CreateAuthorizationHeader(HttpMethod method, Uri url)
    {
        return "AuthHMAC " + _userId + ":" + CreateSignature(method, url);
    }

    private string CreateSignature(
        HttpMethod method,
        Uri url
    )
    {
        var baseline = Encoding.UTF8.GetBytes($"{GetMethodName(method)}&{UrlProvider.Encode(url)}&");
        var hash = _sha1.ComputeHash(baseline);
        return Convert.ToBase64String(hash);
    }

    private static string GetMethodName(HttpMethod method) =>
        method.ToString().ToUpper();

    protected override void Dispose(bool disposing)
    {
        if (IsDisposed)
        {
            return;
        }

        if (disposing)
        {
            _sha1.Dispose();
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