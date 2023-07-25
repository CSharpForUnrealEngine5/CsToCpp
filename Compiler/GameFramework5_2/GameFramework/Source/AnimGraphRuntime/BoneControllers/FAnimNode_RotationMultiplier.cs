#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_RotationMultiplier.h")]
///<summary>Simple controller that multiplies scalar value to the translation/rotation/scale of a single bone.</summary>
public partial struct FAnimNode_RotationMultiplier {
// AnimNode_RotationMultiplier
	public FBoneReference TargetBone;
	public FBoneReference SourceBone;
	public float Multiplier;
	public byte RotationAxisToRefer;
	public bool bIsAdditive;
}
