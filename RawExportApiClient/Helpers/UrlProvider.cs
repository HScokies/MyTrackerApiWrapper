using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace RawExportApiClient.Helpers;

internal sealed class UrlProvider
{
    public static Uri BuildUrl(Uri baseUrl, string path, IEnumerable<KeyValuePair<string, string>> query)
    {
        return new UriBuilder(new Uri(baseUrl, path))
        {
            Query = QueryString.Create(query).ToString()
        }.Uri;
    }

    public static string Encode(Uri url)
    {
        var encoded = HttpUtility.UrlEncode(url.ToString());
        return Regex.Replace(encoded, @"%[a-f0-9]{2}", match => match.Value.ToUpperInvariant());
    }
}