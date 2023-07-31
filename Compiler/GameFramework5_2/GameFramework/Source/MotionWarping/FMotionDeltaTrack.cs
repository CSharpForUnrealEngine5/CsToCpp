#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier_AdjustmentBlendWarp.h")]
public partial struct FMotionDeltaTrack {
	public TArray<FTransform> BoneTransformTrack;
	public TArray<FVector> DeltaTranslationTrack;
	public TArray<FRotator> DeltaRotationTrack;
	public FVector TotalTranslation;
	public FRotator TotalRotation;
}
