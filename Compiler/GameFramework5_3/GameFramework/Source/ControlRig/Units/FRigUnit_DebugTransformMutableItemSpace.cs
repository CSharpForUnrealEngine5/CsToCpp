namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a transform, will draw a point, axis, or a box in the viewport</summary>
[CppInclude("Units/Debug/RigUnit_DebugTransform.h")]
public partial struct FRigUnit_DebugTransformMutableItemSpace {
	public FTransform Transform;
	public ERigUnitDebugTransformMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public FRigElementKey Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
