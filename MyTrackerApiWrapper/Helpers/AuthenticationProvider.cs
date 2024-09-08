using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace MyTrackerApiWrapper.Helpers;

// TODO: Internal
public sealed class AuthenticationProvider : IDisposable
{
    private readonly HMACSHA1 _sha1;

    public AuthenticationProvider(string hashKey) : this(Encoding.UTF8.GetBytes(hashKey))
    {
    }

    public AuthenticationProvider(byte[] hashKey)
    {
        _sha1 = new HMACSHA1(hashKey);
    }

    public string CreateSignature(
        HttpMethod method,
        string url
    )
    {
        var baseline = Encoding.UTF8.GetBytes($"{GetMethodName(method)}&{UrlProvider.Encode(url)}&");
        var hash = _sha1.ComputeHash(baseline);
        return Convert.ToBase64String(hash);
    }

    private static string GetMethodName(HttpMethod method) =>
        method.ToString().ToUpper();

    public void Dispose()
    {
        _sha1.Dispose();
    }
}