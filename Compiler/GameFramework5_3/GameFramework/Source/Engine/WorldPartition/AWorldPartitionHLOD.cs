namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/HLODActor.h")]
public partial class AWorldPartitionHLOD : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>SourceActors</summary>
	public UWorldPartitionHLODSourceActors SourceActors;
	///<summary>HLODBounds</summary>
	public FBox HLODBounds;
	///<summary>MinVisibleDistance</summary>
	public double MinVisibleDistance;
	///<summary>HLODHash</summary>
	public uint HLODHash;
	///<summary>HLODStats</summary>
	public TMap<FName,long> HLODStats;
	///<summary>LODLevel</summary>
	public uint LODLevel;
	///<summary>bRequireWarmup</summary>
	public bool bRequireWarmup;
	///<summary>SourceCellGuid</summary>
	public FGuid SourceCellGuid;
	///<summary>SourceCell_DEPRECATED</summary>
	public TSoftObjectPtr<UWorldPartitionRuntimeCell> SourceCell_DEPRECATED;
	///<summary>SourceCellName_DEPRECATED</summary>
	public FName SourceCellName_DEPRECATED;
	///<summary>HLODSubActors_DEPRECATED</summary>
	public TArray<FHLODSubActor> HLODSubActors_DEPRECATED;
	///<summary>SubActorsHLODLayer_DEPRECATED</summary>
	public UHLODLayer SubActorsHLODLayer_DEPRECATED;
}
