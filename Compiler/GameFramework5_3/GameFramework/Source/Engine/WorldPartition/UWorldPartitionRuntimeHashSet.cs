namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/RuntimeHashSet/WorldPartitionRuntimeHashSet.h")]
public partial class UWorldPartitionRuntimeHashSet : UWorldPartitionRuntimeHash {
	public static UClass StaticClass() {return default;}
	///<summary>Persistent partition</summary>
	public FRuntimePartitionDesc PersistentPartitionDesc;
	///<summary>Array of runtime partition descriptors</summary>
	public TArray<FRuntimePartitionDesc> RuntimePartitions;
	///<summary>NonSpatiallyLoadedRuntimeCells</summary>
	public TArray<UWorldPartitionRuntimeCell> NonSpatiallyLoadedRuntimeCells;
}
