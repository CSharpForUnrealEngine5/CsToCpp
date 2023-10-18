namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for a runtime partition instance.</summary>
[CppInclude("WorldPartition/RuntimeHashSet/WorldPartitionRuntimeHashSet.h")]
public partial struct FRuntimePartitionDesc {
	public UClass Class;
	public FName Name;
	public URuntimePartition MainLayer;
	public UHLODLayer HLODLayer;
	public TArray<FRuntimePartitionHLODSetup> HLODSetups;
}
