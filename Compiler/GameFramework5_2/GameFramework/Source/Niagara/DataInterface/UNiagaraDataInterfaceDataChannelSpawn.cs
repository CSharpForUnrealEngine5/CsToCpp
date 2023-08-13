namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelSpawn.h")]
public partial class UNiagaraDataInterfaceDataChannelSpawn : UNiagaraDataInterfaceDataChannelRead {
	public static UClass StaticClass() {return default;}
	///<summary>The emitter into which we will spawn.</summary>
	public FNiagaraDataInterfaceEmitterBinding EmitterBinding;
	///<summary>If true, we override the SpawnGroup of any generated spawns with the element index of the data channel that generated the spawn.</summary>
	public bool bOverrideSpawnGroupToDataChannelIndex;
}
