#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase {
	public static UClass StaticClass() {return default;}
	///<summary>StreamingGrids</summary>
	public TArray<FSpatialHashStreamingGrid> StreamingGrids;
	///<summary>CellToLevelStreamingPackage</summary>
	public TMap<string,string> CellToLevelStreamingPackage;
}
