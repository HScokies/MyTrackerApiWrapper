using System;

namespace MyTrackerApiWrapper.ExportAPI.ReportDownloader;

public sealed class DownloadRequest : FileRequestBase
{
    // https://app.tracker.my.com/storage/download/raw/19791416.customEvents.20220012.b555ad61dc500b2391a09ad4686b6d9b.csv.gz
    public DownloadRequest(Uri downloadLink) : base(downloadLink)
    {
    }
}