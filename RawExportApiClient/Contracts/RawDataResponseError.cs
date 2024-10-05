using System.Runtime.Serialization;

namespace RawExportApiClient.Contracts;

[DataContract]
internal sealed class RawDataResponseError
{
    [DataMember(Name = "detail")]
    public string Message { get; init; }

    [DataMember(Name = "info")]
    public RawDataResponseErrorInfo ErrorInfo { get; init; }
}