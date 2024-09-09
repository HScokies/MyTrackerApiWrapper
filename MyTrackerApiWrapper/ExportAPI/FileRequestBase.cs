using System;

namespace MyTrackerApiWrapper.ExportAPI;

public abstract class FileRequestBase
{
    internal virtual Uri Path { get; init; }
    
    protected FileRequestBase(Uri path)
    {
        Path = path;
    }
    
    public string DownloadPath { get; set; } 
}