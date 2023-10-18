namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingPolicy.h")]
public partial class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy {
	public static UClass StaticClass() {return default;}
	///<summary>SourceWorldAssetPath</summary>
	public FTopLevelAssetPath SourceWorldAssetPath;
	///<summary>SubObjectsToCellRemapping</summary>
	public TMap<FName,FName> SubObjectsToCellRemapping;
	///<summary>ExternalStreamingObjects</summary>
	public TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> ExternalStreamingObjects;
}
