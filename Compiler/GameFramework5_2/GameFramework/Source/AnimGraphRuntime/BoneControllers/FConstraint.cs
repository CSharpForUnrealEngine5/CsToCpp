#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
