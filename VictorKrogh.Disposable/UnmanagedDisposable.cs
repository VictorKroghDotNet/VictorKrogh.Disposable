
namespace VictorKrogh.Disposable;

public abstract class UnmanagedDisposable : Disposable
{
    ~UnmanagedDisposable()
    {
        Dispose(false);
    }
}
