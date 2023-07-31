#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple controller that multiplies scalar value to the translation/rotation/scale of a single bone.</summary>
[CppInclude("BoneControllers/AnimNode_RotationMultiplier.h")]
public partial struct FAnimNode_RotationMultiplier {
	public FBoneReference TargetBone;
	public FBoneReference SourceBone;
	public float Multiplier;
	public EBoneAxis RotationAxisToRefer;
	public bool bIsAdditive;
}
