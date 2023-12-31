namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constraint Data that is contained in Node Datat</summary>
[CppInclude("Constraint.h")]
public partial struct FConstraintData {
	public FConstraintDescriptor Constraint;
	public float Weight;
	public bool bMaintainOffset;
	public FTransform Offset;
	public FTransform CurrentTransform;
}
