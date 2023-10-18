#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public partial struct TArray<T>
{
    public T GetData() { return default; }
    public static int GetTypeSize() { return 0; }
    public long GetAllocatedSize() { return 0; }
    public long GetSlack() { return 0; }
    public bool IsValidIndex(int Index) { return false; }
    public bool IsEmpty() { return false; }
    public long Num() { return 0; }
    public long Max() { return 0; }
    public T this[int Index] { get { return default; } set { } } 
    public T Pop() { return default; }
    public void Push(T Value) { }
    public T Top() { return default; }
    public T Last(int IndexFromTheEnd = 0) { return default; }
    public void Shrink() { }

    public bool Find(T Value, int Index) { return default; }
    public long Find(T Value) { return 0; }
    public long FindLast(T Value) { return 0; }
    public long Insert(T Value, int Index) { return default; }
    public void RemoveAt(int Index) { }
    public void RemoveAtSwap(int Index) { }
    public void RemoveAt(int Index, int Count, bool bAllowShrinking = true) { }
    public void Reset(int NewSize = 0) { }
    public void Empty(int NewSize = 0) { }
    public void SetNum(int NewNum, bool bAllowShrinking = true) { }
    public void SetNumZeroed(int NewNum, bool bAllowShrinking = true) { }
    public long Add(T Value) { return default; }

}
