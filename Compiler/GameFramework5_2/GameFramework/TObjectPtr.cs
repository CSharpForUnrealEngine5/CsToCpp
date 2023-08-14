#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public struct TObjectPtr<T>
{
}

public struct TLazyObjectPtr<T>
{
}

public struct TSoftObjectPtr<T>
{
}

public struct TWeakObjectPtr<T>
{
    public T Get() { return default; }
}
