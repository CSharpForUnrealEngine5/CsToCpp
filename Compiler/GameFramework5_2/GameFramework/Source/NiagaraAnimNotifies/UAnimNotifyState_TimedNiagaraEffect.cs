#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNotifyState_TimedNiagaraEffect.h")]
///<summary>Timed Niagara Effect Notify</summary>
public partial class UAnimNotifyState_TimedNiagaraEffect : UAnimNotifyState {
// AnimNotifyState_TimedNiagaraEffect
	public UNiagaraSystem Template;
	public string SocketName;
	public FVector LocationOffset;
	public FRotator RotationOffset;
	public bool bDestroyAtEnd;
	public UObject GetSpawnedEffect(UObject MeshComp) { return default; }
}
