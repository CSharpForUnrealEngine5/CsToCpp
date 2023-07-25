#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_OffsetRootBone.h")]
public partial struct FAnimNode_OffsetRootBone {
// AnimNode_OffsetRootBone
	public EWarpingEvaluationMode EvaluationMode;
	public EOffsetRootBoneMode TranslationMode;
	public EOffsetRootBoneMode RotationMode;
	public float TranslationHalflife;
	public float RotationHalfLife;
	public float MaxTranslationError;
	public float MaxRotationError;
	public bool bClampToTranslationVelocity;
	public bool bClampToRotationVelocity;
	public float TranslationSpeedRatio;
	public float RotationSpeedRatio;
	public FVector TranslationDelta;
	public FRotator RotationDelta;
}
