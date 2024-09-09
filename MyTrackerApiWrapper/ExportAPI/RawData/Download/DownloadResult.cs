using System.IO;

namespace MyTrackerApiWrapper.ExportAPI.ReportDownloader;

public sealed class DownloadResult
{
    public bool IsSuccess { get; init; }
    public Stream File { get; init; }
    public string FilePath { get; init; }
}