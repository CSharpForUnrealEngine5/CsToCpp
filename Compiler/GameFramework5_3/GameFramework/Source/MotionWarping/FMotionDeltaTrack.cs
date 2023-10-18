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
