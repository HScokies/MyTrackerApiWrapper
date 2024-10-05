using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RawExportApiClient.Contracts;

[DataContract]
internal sealed class RawDataResponseData
{
    /// <summary>
    /// Export identifier
    /// </summary>
    [DataMember(Name = "idRawExport")]
    public int RawExportId { get; init; }

    /// <summary>
    /// Used in success response from Cancel request
    /// </summary>
    [DataMember(Name = "info")]
    public string CancelMessage { get; init; }

    /// <summary>
    /// Export status ( In progress / Error occurred / User error occurred / Canceled by user) 
    /// </summary>
    [DataMember(Name = "status")]
    public string ReportStatus { get; init; }

    /// <summary>
    /// Export progress percentage 
    /// </summary>
    [DataMember(Name = "progress")]
    public string ExportProgress { get; init; }

    /// <summary>
    /// Was export cancelled 
    /// </summary>
    [DataMember(Name = "isCancellable")]
    public bool IsCancelled { get; init; }

    /// <summary>
    /// Download link and expiration date for exports  
    /// </summary>
    [DataMember(Name = "files")]
    public ICollection<RawDataGetResponseFile> Files { get; init; }

    /// <summary>
    /// Error message from Get request
    /// </summary>
    [DataMember(Name = "errorMessage")]
    public string ErrorMessage { get; init; }

    /// <summary>
    /// Error details
    /// </summary>
    [DataMember(Name = "error")]
    public RawDataResponseError Error { get; init; }
}