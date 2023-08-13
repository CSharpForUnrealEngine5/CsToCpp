namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a transform, will draw a point, axis, or a box in the viewport</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugTransform.h")]
public partial struct FRigVMFunction_DebugTransformMutableNoSpace {
	public FTransform Transform;
	public ERigUnitDebugTransformMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public FTransform WorldOffset;
	public bool bEnabled;
}
