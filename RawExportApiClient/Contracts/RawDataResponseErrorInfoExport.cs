using System.Runtime.Serialization;

namespace RawExportApiClient.Contracts;

[DataContract]
internal class RawDataResponseErrorInfoExport
{
    [DataMember(Name = "idRawExport")]
    public int RawExportId { get; init; }
}