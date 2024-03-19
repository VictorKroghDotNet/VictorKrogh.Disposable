namespace VictorKrogh;

public abstract class UnmanagedDisposable : Disposable
{
    ~UnmanagedDisposable()
    {
        Dispose(false);
    }
}
