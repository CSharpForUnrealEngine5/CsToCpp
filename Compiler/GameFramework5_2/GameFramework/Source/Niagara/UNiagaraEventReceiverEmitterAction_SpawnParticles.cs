namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEvents.h")]
public partial class UNiagaraEventReceiverEmitterAction_SpawnParticles : UNiagaraEventReceiverEmitterAction {
	public static UClass StaticClass() {return default;}
	///<summary>Number of particles to spawn per event received.</summary>
	public uint NumParticles;
}
