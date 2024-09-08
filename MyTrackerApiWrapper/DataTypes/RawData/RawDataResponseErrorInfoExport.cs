using System.Runtime.Serialization;

namespace MyTrackerApiWrapper.DataTypes.RawData;

[DataContract]
internal class RawDataResponseErrorInfoExport
{
    [DataMember(Name = "idRawExport")]
    public int RawExportId { get; init; }
}