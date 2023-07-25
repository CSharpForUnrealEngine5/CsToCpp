#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComponentInstanceDataCache.h")]
///<summary>Base class for instance cached data of a particular type.</summary>
public partial struct FInstanceCacheDataBase {
// InstanceCacheDataBase
	public TArray<byte> SavedProperties;
	public FDataCacheDuplicatedObjectData UniqueTransientPackage;
	public TArray<FDataCacheDuplicatedObjectData> DuplicatedObjects;
	public TArray<UObject> ReferencedObjects;
	public TArray<string> ReferencedNames;
}
