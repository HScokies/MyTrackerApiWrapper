using System;
using System.IO;
using System.Threading.Tasks;
using RawExportApiClient.Abstractions;

namespace RawExportApiClient.Commands.Download;

public sealed class DownloadResult : DisposableWrapperBase
{
    protected override bool IsDisposed { get; set; }

    public bool IsSuccess { get; init; }
    public string Message { get; init; }
    public Stream Stream { get; init; }
    public string FilePath { get; init; }


    protected override void Dispose(bool disposing)
    {
        if (IsDisposed)
        {
            return;
        }

        if (disposing)
        {
            Stream?.Dispose();
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }

        IsDisposed = true;
    }

    public override void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public override ValueTask DisposeAsync()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
        return new ValueTask();
    }
}