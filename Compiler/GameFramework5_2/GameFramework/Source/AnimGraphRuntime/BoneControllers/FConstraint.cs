#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_Constraint.h")]
///<summary>Constraint Set up</summary>
public partial struct FConstraint {
// Constraint
	public FBoneReference TargetBone;
	public EConstraintOffsetOption OffsetOption;
	public ETransformConstraintType TransformType;
	public FFilterOptionPerAxis PerAxis;
}
