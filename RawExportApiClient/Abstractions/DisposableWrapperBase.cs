using System;
using System.Threading.Tasks;

namespace RawExportApiClient.Abstractions;

public abstract class DisposableWrapperBase : IDisposable, IAsyncDisposable
{
    protected abstract bool IsDisposed { get; set; }
    protected abstract void Dispose(bool disposing);

    public abstract void Dispose();

    public abstract ValueTask DisposeAsync();
}