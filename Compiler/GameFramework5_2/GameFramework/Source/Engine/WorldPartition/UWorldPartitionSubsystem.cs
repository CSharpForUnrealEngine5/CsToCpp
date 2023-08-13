namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UWorldPartitionSubsystem</summary>
[CppInclude("WorldPartition/WorldPartitionSubsystem.h")]
public partial class UWorldPartitionSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>IsStreamingCompleted</summary>
	public bool IsStreamingCompleted(EWorldPartitionRuntimeCellState QueryState,TArray<FWorldPartitionStreamingQuerySource> QuerySources,bool bExactState) { return default; }
	///<summary>Returns true if world partition is done streaming levels, adding them to the world or removing them from the world.</summary>
	public bool IsAllStreamingCompleted() { return default; }
}
