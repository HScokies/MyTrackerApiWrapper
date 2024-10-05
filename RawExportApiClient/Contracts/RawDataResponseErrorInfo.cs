using System.Runtime.Serialization;

namespace RawExportApiClient.Contracts;

[DataContract]
internal sealed class RawDataResponseErrorInfo
{
    [DataMember(Name = "exports")]
    public RawDataResponseErrorInfoExport Exports { get; init; }
}