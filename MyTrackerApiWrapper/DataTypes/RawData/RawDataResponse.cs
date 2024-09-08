using System.Runtime.Serialization;

namespace MyTrackerApiWrapper.DataTypes.RawData;

[DataContract]
internal sealed class RawDataResponse
{
    /// <summary>
    /// Status code
    /// </summary>
    [DataMember(Name = "code")]
    public int Code { get; init; }
    
    /// <summary>
    /// Status code text
    /// </summary>
    [DataMember(Name = "message")]
    public string Message { get; init; }
    
    /// <summary>
    /// Response data
    /// </summary>
    [DataMember(Name = "data")]
    public RawDataResponseData Result { get; init; }
}