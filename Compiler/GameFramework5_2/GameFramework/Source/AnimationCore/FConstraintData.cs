#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
///<summary>Constraint Data that is contained in Node Datat</summary>
public partial struct FConstraintData {
// ConstraintData
	public FConstraintDescriptor Constraint;
	public float Weight;
	public bool bMaintainOffset;
	public FTransform Offset;
	public FTransform CurrentTransform;
}
