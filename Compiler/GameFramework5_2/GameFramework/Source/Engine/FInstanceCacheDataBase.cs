namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for instance cached data of a particular type.</summary>
[CppInclude("ComponentInstanceDataCache.h")]
public partial struct FInstanceCacheDataBase {
	public TArray<byte> SavedProperties;
	public FDataCacheDuplicatedObjectData UniqueTransientPackage;
	public TArray<FDataCacheDuplicatedObjectData> DuplicatedObjects;
	public TArray<UObject> ReferencedObjects;
	public TArray<string> ReferencedNames;
}
