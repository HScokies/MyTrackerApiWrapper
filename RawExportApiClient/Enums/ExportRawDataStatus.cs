namespace RawExportApiClient.Enums;

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