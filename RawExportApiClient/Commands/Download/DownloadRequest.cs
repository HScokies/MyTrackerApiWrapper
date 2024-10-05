using System;

namespace RawExportApiClient.Commands.Download;

public sealed class DownloadRequest : FileRequestBase
{
    public DownloadRequest(Uri downloadLink) : base(downloadLink)
    {
    }
}