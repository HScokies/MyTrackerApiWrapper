using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace MyTrackerApiWrapper.Helpers;

// TODO: Internal
public sealed class AuthorizationProvider : IDisposable
{
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

    public void Dispose()
    {
        _sha1.Dispose();
    }
}