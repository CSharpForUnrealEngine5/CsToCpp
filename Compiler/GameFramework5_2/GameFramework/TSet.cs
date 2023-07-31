namespace GameFramework;

public partial struct TSet<T>
{
    public void Empty(int ExpectedNumElements = 0) { }
    public void Reset() { }
    public void Shrink() { }
    public void Compact() { }
    public void CompactStable() { }
    public void Reserve(int Number) { }
    public bool IsEmpty() { return false; }
    public int Num() { return 0; }
    public long GetAllocatedSize() { return 0; }

    public void Add(T Value) { }
}

