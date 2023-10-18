namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/RuntimeHashSet/WorldPartitionRuntimeHashSet.h")]
public partial class URuntimeHashSetExternalStreamingObject : URuntimeHashExternalStreamingObjectBase {
	public static UClass StaticClass() {return default;}
	///<summary>NonSpatiallyLoadedRuntimeCells</summary>
	public TArray<UWorldPartitionRuntimeCell> NonSpatiallyLoadedRuntimeCells;
	///<summary>SpatiallyLoadedRuntimeCells</summary>
	public TArray<UWorldPartitionRuntimeCell> SpatiallyLoadedRuntimeCells;
}
