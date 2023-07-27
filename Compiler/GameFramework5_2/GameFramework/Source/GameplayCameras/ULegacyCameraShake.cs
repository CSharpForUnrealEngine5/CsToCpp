#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LegacyCameraShake.h")]
///<summary>Legacy camera shake which can do either oscillation or run camera anims.</summary>
public partial class ULegacyCameraShake : UCameraShakeBase {
// LegacyCameraShake
	public float OscillationDuration;
	public float OscillationBlendInTime;
	public float OscillationBlendOutTime;
	public FROscillator RotOscillation;
	public FVOscillator LocOscillation;
	public FFOscillator FOVOscillation;
	public float AnimPlayRate;
	public float AnimScale;
	public float AnimBlendInTime;
	public float AnimBlendOutTime;
	public float RandomAnimSegmentDuration;
	public UCameraAnimationSequence AnimSequence;
	public bool bRandomAnimSegment;
	public float OscillatorTimeRemaining;
	public  void ReceivePlayShake(float Scale) {}
	public  void BlueprintUpdateCameraShake(float DeltaTime,float Alpha,FMinimalViewInfo POV,FMinimalViewInfo ModifiedPOV) {}
	public  bool ReceiveIsFinished() { return default; }
	public  void ReceiveStopShake(bool bImmediately) {}
	public static ULegacyCameraShake StartLegacyCameraShake(APlayerCameraManager PlayerCameraManager,UClass ShakeClass,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	public static ULegacyCameraShake StartLegacyCameraShakeFromSource(APlayerCameraManager PlayerCameraManager,UClass ShakeClass,UCameraShakeSourceComponent SourceComponent,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	public USequenceCameraShakePattern SequenceShakePattern;
}
