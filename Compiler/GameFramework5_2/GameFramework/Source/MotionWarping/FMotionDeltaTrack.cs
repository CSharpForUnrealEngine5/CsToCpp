#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier_AdjustmentBlendWarp.h")]
public partial struct FMotionDeltaTrack {
// MotionDeltaTrack
	public TArray<FTransform> BoneTransformTrack;
	public TArray<FVector> DeltaTranslationTrack;
	public TArray<FRotator> DeltaRotationTrack;
	public FVector TotalTranslation;
	public FRotator TotalRotation;
}
