#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Timed Particle Effect Notify</summary>
[CppInclude("Animation/AnimNotifies/AnimNotifyState_TimedParticleEffect.h")]
public partial class UAnimNotifyState_TimedParticleEffect : UAnimNotifyState {
	///<summary>The particle system to spawn for the notify state</summary>
	public UParticleSystem PSTemplate;
	///<summary>The socket or bone to attach the system to</summary>
	public string SocketName;
	///<summary>Offset from the socket or bone to place the particle system</summary>
	public FVector LocationOffset;
	///<summary>Rotation offset from the socket or bone for the particle system</summary>
	public FRotator RotationOffset;
	///<summary>Whether the particle system should be immediately destroyed at the end of the notify state or be allowed to finish</summary>
	public bool bDestroyAtEnd;
	///<summary>The following arrays are used to handle property changes during a state. Because we can&#39;t</summary>
	public TArray<UParticleSystem> PreviousPSTemplates;
	///<summary>PreviousSocketNames</summary>
	public TArray<string> PreviousSocketNames;
}
