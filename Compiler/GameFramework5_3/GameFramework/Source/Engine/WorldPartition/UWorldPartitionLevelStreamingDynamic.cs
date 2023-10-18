namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingDynamic.h")]
public partial class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic {
	public static UClass StaticClass() {return default;}
	///<summary>RuntimeLevel</summary>
	public ULevel RuntimeLevel;
	///<summary>bShouldBeAlwaysLoaded</summary>
	public bool bShouldBeAlwaysLoaded;
	///<summary>bShouldPerformStandardLevelLoading</summary>
	public bool bShouldPerformStandardLevelLoading;
	///<summary>UnsavedActorsContainer</summary>
	public UActorContainer UnsavedActorsContainer;
	///<summary>StreamingCell</summary>
	public TWeakObjectPtr<UWorldPartitionRuntimeLevelStreamingCell> StreamingCell;
	///<summary>OuterWorldPartition</summary>
	public UWorldPartition OuterWorldPartition;
}
