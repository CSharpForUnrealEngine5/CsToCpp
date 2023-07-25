#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotify_PlayParticleEffect.h")]
public partial class UAnimNotify_PlayParticleEffect : UAnimNotify {
// AnimNotify_PlayParticleEffect
	public UParticleSystem PSTemplate;
	public FVector LocationOffset;
	public FRotator RotationOffset;
	public FVector Scale;
	public bool Attached;
	public string SocketName;
}
