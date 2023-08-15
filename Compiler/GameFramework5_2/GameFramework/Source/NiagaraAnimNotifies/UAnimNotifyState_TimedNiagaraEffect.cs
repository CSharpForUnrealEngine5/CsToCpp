namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Timed Niagara Effect Notify</summary>
[CppInclude("AnimNotifyState_TimedNiagaraEffect.h")]
public partial class UAnimNotifyState_TimedNiagaraEffect : UAnimNotifyState {
	public static UClass StaticClass() {return default;}
	///<summary>The niagara system to spawn for the notify state</summary>
	public UNiagaraSystem Template;
	///<summary>The socket or bone to attach the system to</summary>
	public FName SocketName;
	///<summary>Offset from the socket or bone to place the Niagara system</summary>
	public FVector LocationOffset;
	///<summary>Rotation offset from the socket or bone for the Niagara system</summary>
	public FRotator RotationOffset;
	///<summary>Whether the Niagara system should be immediately destroyed at the end of the notify state or be allowed to finish</summary>
	public bool bDestroyAtEnd;
	///<summary>Return FXSystemComponent created from SpawnEffect</summary>
	public UFXSystemComponent GetSpawnedEffect(UMeshComponent MeshComp) { return default; }
}
