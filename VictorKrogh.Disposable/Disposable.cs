namespace VictorKrogh;

public abstract class Disposable : IDisposable, IAsyncDisposable
{
    private bool isDisposed;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public ValueTask DisposeAsync()
    {
        Dispose();

        return ValueTask.CompletedTask;
    }

    protected void Dispose(bool disposing)
    {
        if (isDisposed)
        {
            throw new ObjectDisposedException($"'{GetType().FullName}' has already been disposed!");
        }

        if (disposing)
        {
            DisposeManagedState();
        }

        FreeUnmanagedResources();

        ClearLargeFields();

        isDisposed = true;
    }

    protected virtual void DisposeManagedState()
    {
    }

    protected virtual void FreeUnmanagedResources()
    {
    }

    protected virtual void ClearLargeFields()
    {
    }
}
