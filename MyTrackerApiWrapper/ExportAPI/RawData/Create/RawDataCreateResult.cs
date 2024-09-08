using MyTrackerApiWrapper.DataTypes.RawData;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Create;

public sealed class RawDataCreateResult
{
    public bool IsSuccess { get; init; }
    
    public int? ExportRequestId { get; init; }
    public string Message { get; init; }
}