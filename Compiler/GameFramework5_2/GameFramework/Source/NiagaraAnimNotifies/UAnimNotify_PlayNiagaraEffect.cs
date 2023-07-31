#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNotify_PlayNiagaraEffect.h")]
public partial class UAnimNotify_PlayNiagaraEffect : UAnimNotify {
	///<summary>Niagara System to Spawn</summary>
	public UNiagaraSystem Template;
	///<summary>Location offset from the socket</summary>
	public FVector LocationOffset;
	///<summary>Rotation offset from socket</summary>
	public FRotator RotationOffset;
	///<summary>Scale to spawn the Niagara system at</summary>
	public FVector Scale;
	///<summary>Whether or not we are in absolute scale mode</summary>
	public bool bAbsoluteScale;
	///<summary>Return FXSystemComponent created from SpawnEffect</summary>
	public  UFXSystemComponent GetSpawnedEffect() { return default; }
	///<summary>Should attach to the bone/socket</summary>
	public bool Attached;
	///<summary>SocketName to attach to</summary>
	public string SocketName;
}
