namespace MyTrackerApiWrapper.ExportAPI.RawData.Get.Result;

/// <summary>
/// Represents raw data export status
/// </summary>
public enum ExportRawDataStatus
{
    InProgress,
    Error,
    UserError,
    Canceled,
    Undocumented
}