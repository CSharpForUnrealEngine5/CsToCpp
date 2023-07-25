#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase {
// RuntimeSpatialHashExternalStreamingObject
	public TArray<FSpatialHashStreamingGrid> StreamingGrids;
	public TMap<string,string> CellToLevelStreamingPackage;
}
