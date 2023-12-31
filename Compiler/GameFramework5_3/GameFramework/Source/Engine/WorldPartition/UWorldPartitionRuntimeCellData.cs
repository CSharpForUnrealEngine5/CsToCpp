namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Caches information on streaming source that will be used later on to sort cell.</summary>
[CppInclude("WorldPartition/WorldPartitionRuntimeCellData.h")]
public partial class UWorldPartitionRuntimeCellData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ContentBounds</summary>
	public FBox ContentBounds;
}
