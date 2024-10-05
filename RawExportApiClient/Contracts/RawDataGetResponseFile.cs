using System;
using System.Runtime.Serialization;

namespace RawExportApiClient.Contracts;

[DataContract]
internal sealed class RawDataGetResponseFile
{
    /// <summary>
    /// File download link
    /// </summary>
    [DataMember(Name = "link")]
    public Uri DownloadLink { get; init; }

    /// <summary>
    /// File expiration unix timestamp in seconds 
    /// </summary>
    [DataMember(Name = "timestampExpires")]
    public long Expires { get; init; }
}