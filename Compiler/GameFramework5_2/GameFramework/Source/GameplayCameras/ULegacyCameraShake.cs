#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Legacy camera shake which can do either oscillation or run camera anims.</summary>
[CppInclude("LegacyCameraShake.h")]
public partial class ULegacyCameraShake : UCameraShakeBase {
	///<summary>Duration in seconds of current screen shake. Less than 0 means indefinite, 0 means no oscillation.</summary>
	public float OscillationDuration;
	///<summary>Duration of the blend-in, where the oscillation scales from 0 to 1.</summary>
	public float OscillationBlendInTime;
	///<summary>Duration of the blend-out, where the oscillation scales from 1 to 0.</summary>
	public float OscillationBlendOutTime;
	///<summary>Rotational oscillation</summary>
	public FROscillator RotOscillation;
	///<summary>Positional oscillation</summary>
	public FVOscillator LocOscillation;
	///<summary>FOV oscillation</summary>
	public FFOscillator FOVOscillation;
	///<summary>Scalar defining how fast to play the anim.</summary>
	public float AnimPlayRate;
	///<summary>Scalar defining how &quot;intense&quot; to play the anim.</summary>
	public float AnimScale;
	///<summary>Linear blend-in time.</summary>
	public float AnimBlendInTime;
	///<summary>Linear blend-out time.</summary>
	public float AnimBlendOutTime;
	///<summary>When bRandomAnimSegment is true, this defines how long the anim should play.</summary>
	public float RandomAnimSegmentDuration;
	///<summary>Source camera animation sequence to play. Can be null.</summary>
	public UCameraAnimationSequence AnimSequence;
	///<summary>If true, play a random snippet of the animation of length Duration.  Implies bLoop and bRandomStartTime = true for the AnimSequence.</summary>
	public bool bRandomAnimSegment;
	///<summary>Time remaining for oscillation shakes. Less than 0.f means shake infinitely.</summary>
	public float OscillatorTimeRemaining;
	///<summary>Called when the shake starts playing</summary>
	public  void ReceivePlayShake(float Scale) {}
	///<summary>Called every tick to let the shake modify the point of view</summary>
	public  void BlueprintUpdateCameraShake(float DeltaTime,float Alpha,FMinimalViewInfo POV,FMinimalViewInfo ModifiedPOV) {}
	///<summary>Called to allow a shake to decide when it&#39;s finished playing.</summary>
	public  bool ReceiveIsFinished() { return default; }
	///<summary>Called when the shake is explicitly stopped.</summary>
	public  void ReceiveStopShake(bool bImmediately) {}
	///<summary>Backwards compatible method used by core BP redirectors. This is needed because the return value is specifically a legacy camera shake,</summary>
	public static ULegacyCameraShake StartLegacyCameraShake(APlayerCameraManager PlayerCameraManager,UClass ShakeClass,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	///<summary>Backwards compatible method used by core BP redirectors. This is needed because the return value is specifically a legacy camera shake,</summary>
	public static ULegacyCameraShake StartLegacyCameraShakeFromSource(APlayerCameraManager PlayerCameraManager,UClass ShakeClass,UCameraShakeSourceComponent SourceComponent,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	///<summary>Sequence shake pattern for when using a sequence instead of a camera anim</summary>
	public USequenceCameraShakePattern SequenceShakePattern;
}
