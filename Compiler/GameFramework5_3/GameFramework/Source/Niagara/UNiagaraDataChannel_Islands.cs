namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannel_Islands.h")]
public partial class UNiagaraDataChannel_Islands : UNiagaraDataChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Controls how islands are placed and sized.</summary>
	public ENiagraDataChannel_IslandMode Mode;
	///<summary>Starting extents of the island&#39;s bounds.</summary>
	public FVector InitialExtents;
	///<summary>The maximum total extents of each island. If a new element would grow the bounds beyond this size then a new island is created.</summary>
	public FVector MaxExtents;
	///<summary>The extents for every element entered into this data channel.</summary>
	public FVector PerElementExtents;
	///<summary>One or more Niagara Systems to spawn that will consume the data in this island.</summary>
	public TArray<TSoftObjectPtr<UNiagaraSystem>> Systems;
	///<summary>How many pre-allocated islands to keep in the pool. Higher values will incur a larger standing memory cost but will reduce activation times for new islands.</summary>
	public int IslandPoolSize;
	///<summary>DebugDrawSettings</summary>
	public FNDCIslandDebugDrawSettings DebugDrawSettings;
	///<summary>SystemsInternal</summary>
	public TArray<UNiagaraSystem> SystemsInternal;
}
