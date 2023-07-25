#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotifyState_TimedParticleEffect.h")]
///<summary>Timed Particle Effect Notify</summary>
public partial class UAnimNotifyState_TimedParticleEffect : UAnimNotifyState {
// AnimNotifyState_TimedParticleEffect
	public UParticleSystem PSTemplate;
	public string SocketName;
	public FVector LocationOffset;
	public FRotator RotationOffset;
	public bool bDestroyAtEnd;
	public TArray<UParticleSystem> PreviousPSTemplates;
	public TArray<string> PreviousSocketNames;
}
