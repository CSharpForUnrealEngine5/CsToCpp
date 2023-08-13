namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constraint Set up</summary>
[CppInclude("BoneControllers/AnimNode_Constraint.h")]
public partial struct FConstraint {
	public FBoneReference TargetBone;
	public EConstraintOffsetOption OffsetOption;
	public ETransformConstraintType TransformType;
	public FFilterOptionPerAxis PerAxis;
}
