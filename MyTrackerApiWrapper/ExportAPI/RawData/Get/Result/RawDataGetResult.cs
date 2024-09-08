using System.Collections.Generic;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Get.Result;

public sealed class RawDataGetResult
{
    public bool IsSuccess { get; init; }
    
    public bool IsCompleted { get; init; }
    public string Progress { get; init; }
    public ExportRawDataStatus ReportStatus { get; init; }
    public string Message { get; init; }
    public IEnumerable<ExportData> Files { get; init; }
}