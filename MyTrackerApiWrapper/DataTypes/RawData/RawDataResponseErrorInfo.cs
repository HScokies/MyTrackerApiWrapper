using System.Runtime.Serialization;

namespace MyTrackerApiWrapper.DataTypes.RawData;

[DataContract]
internal sealed class RawDataResponseErrorInfo
{
    [DataMember(Name = "exports")]
    public RawDataResponseErrorInfoExport Exports { get; init; }
}