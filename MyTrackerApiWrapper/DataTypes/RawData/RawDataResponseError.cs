using System.Runtime.Serialization;

namespace MyTrackerApiWrapper.DataTypes.RawData;

[DataContract]
internal sealed class RawDataResponseError
{
    [DataMember(Name = "detail")]
    public string Message { get; init; }
    
    [DataMember(Name = "info")]
    public RawDataResponseErrorInfo ErrorInfo { get; init; }
}