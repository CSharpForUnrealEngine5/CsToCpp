namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotify_PlayParticleEffect.h")]
public partial class UAnimNotify_PlayParticleEffect : UAnimNotify {
	public static UClass StaticClass() {return default;}
	///<summary>Particle System to Spawn</summary>
	public UParticleSystem PSTemplate;
	///<summary>Location offset from the socket</summary>
	public FVector LocationOffset;
	///<summary>Rotation offset from socket</summary>
	public FRotator RotationOffset;
	///<summary>Scale to spawn the particle system at</summary>
	public FVector Scale;
	///<summary>Should attach to the bone/socket</summary>
	public bool Attached;
	///<summary>SocketName to attach to</summary>
	public string SocketName;
}
