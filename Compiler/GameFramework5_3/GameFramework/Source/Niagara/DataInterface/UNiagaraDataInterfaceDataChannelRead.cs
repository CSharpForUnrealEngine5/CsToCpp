namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelRead.h")]
public partial class UNiagaraDataInterfaceDataChannelRead : UNiagaraDataInterfaceRWBase {
	public static UClass StaticClass() {return default;}
	///<summary>When reading from external, the channel to consume.</summary>
	public UNiagaraDataChannelAsset Channel;
	///<summary>A bounds emitter instance when using functions like Spawn. Defaults to Self.</summary>
	public FNiagaraDataInterfaceEmitterBinding EmitterBinding;
	///<summary>True if this reader will read the current frame&#39;s data. If false, we read the previous frame.</summary>
	public bool bReadCurrentFrame;
	///<summary>Whether this DI should request updated source data from the Data Channel each tick.</summary>
	public bool bUpdateSourceDataEveryTick;
	///<summary>When true, Emitter.Spawn group for any spawned particles will be overridden to the index of the data channel element that generated that spawn. This allows particles to read further data from the data channel element that generated them.</summary>
	public bool bOverrideSpawnGroupToDataChannelIndex;
	///<summary>The spawn info variable we&#39;ll read from the data channel to control spawning using the SpawnFromSpawnInfo DI function.</summary>
	public FName SpawnInfoName;
	///<summary>CompiledData</summary>
	public FNDIDataChannelCompiledData CompiledData;
}
