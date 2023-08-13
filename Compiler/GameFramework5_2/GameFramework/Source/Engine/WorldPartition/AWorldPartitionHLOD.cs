namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/HLODActor.h")]
public partial class AWorldPartitionHLOD : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>HLODSubActors</summary>
	public TArray<FHLODSubActor> HLODSubActors;
	///<summary>SubActorsHLODLayer</summary>
	public UHLODLayer SubActorsHLODLayer;
	///<summary>HLODBounds</summary>
	public FBox HLODBounds;
	///<summary>MinVisibleDistance</summary>
	public double MinVisibleDistance;
	///<summary>HLODHash</summary>
	public uint HLODHash;
	///<summary>HLODStats</summary>
	public TMap<string,long> HLODStats;
	///<summary>LODLevel</summary>
	public uint LODLevel;
	///<summary>bRequireWarmup</summary>
	public bool bRequireWarmup;
	///<summary>SourceCell_DEPRECATED</summary>
	public TSoftObjectPtr<UWorldPartitionRuntimeCell> SourceCell_DEPRECATED;
	///<summary>SourceCellName_DEPRECATED</summary>
	public string SourceCellName_DEPRECATED;
	///<summary>SourceCellGuid</summary>
	public FGuid SourceCellGuid;
}
