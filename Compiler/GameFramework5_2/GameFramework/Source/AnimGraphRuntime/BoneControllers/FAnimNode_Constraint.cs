namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constraint node to parent or world transform for rotation/translation</summary>
[CppInclude("BoneControllers/AnimNode_Constraint.h")]
public partial struct FAnimNode_Constraint {
	public FBoneReference BoneToModify;
	public TArray<FConstraint> ConstraintSetup;
	public TArray<float> ConstraintWeights;
}
