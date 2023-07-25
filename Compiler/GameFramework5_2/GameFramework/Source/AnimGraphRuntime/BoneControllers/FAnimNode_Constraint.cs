#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_Constraint.h")]
///<summary>Constraint node to parent or world transform for rotation/translation</summary>
public partial struct FAnimNode_Constraint {
// AnimNode_Constraint
	public FBoneReference BoneToModify;
	public TArray<FConstraint> ConstraintSetup;
	public TArray<float> ConstraintWeights;
}
