namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase {
	public static UClass StaticClass() {return default;}
	///<summary>StreamingGrids</summary>
	public TArray<FSpatialHashStreamingGrid> StreamingGrids;
}
