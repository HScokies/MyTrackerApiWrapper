using System;

namespace RawExportApiClient.Commands;

public abstract class FileRequestBase
{
    internal Uri Path { get; init; }

    protected FileRequestBase(Uri path)
    {
        Path = path;
    }

    public string DownloadPath { get; set; }
}