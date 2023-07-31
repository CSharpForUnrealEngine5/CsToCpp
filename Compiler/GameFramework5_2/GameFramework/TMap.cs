namespace GameFramework;

public partial struct TMap<K,V>
{
    public void Empty(int ExpectedNumElements = 0) { }
    public void Reset() { }
    public void Shrink() { }
    public void Compact() { }
    public void CompactStable() { }
    public void Reserve(int Number) { }
    public bool IsEmpty() { return false; }
    public int Num() { return 0; }
    public int GetKeys(TArray<K> Keys) { return 0; }
    public long GetAllocatedSize() { return 0; }
    public V Add(K Key, V  Value) { return default; }

    public int Remove(K Key) { return 0; }
    public K FindKey(V Value) { return default; }

    public V Find(K Key) { return default; }

    public V FindOrAdd(K Key, V Value) { return default; }
    public bool Contains(K Key) { return false; }

    public void GenerateKeyArray(TArray<K> Keys) { }
    public void GenerateValueArray(TArray<V> Values) { }
}
