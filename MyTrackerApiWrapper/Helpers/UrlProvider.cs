using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace MyTrackerApiWrapper.Helpers;

// TODO: Internal
public sealed class UrlProvider
{
    public static Uri BuildUrl(string baseUrl, string path, ICollection<KeyValuePair<string, string>> query)
    {
        var url = baseUrl + path; // TODO: Remove
        
        return new UriBuilder(url)
        {
            Query = QueryString.Create(query).ToString()
        }.Uri;
    }
    
    public static string Encode(string url)
    {
        var encoded = HttpUtility.UrlEncode(url);
        return Regex.Replace(encoded, @"%[a-f0-9]{2}", match => match.Value.ToUpperInvariant());
    }
}