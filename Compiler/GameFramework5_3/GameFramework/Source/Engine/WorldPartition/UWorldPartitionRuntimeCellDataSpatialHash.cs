namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeCellDataSpatialHash.h")]
public partial class UWorldPartitionRuntimeCellDataSpatialHash : UWorldPartitionRuntimeCellData {
	public static UClass StaticClass() {return default;}
	///<summary>Position</summary>
	public FVector Position;
	///<summary>Extent</summary>
	public float Extent;
	///<summary>Level</summary>
	public int Level;
	///<summary>GridName</summary>
	public FName GridName;
}
