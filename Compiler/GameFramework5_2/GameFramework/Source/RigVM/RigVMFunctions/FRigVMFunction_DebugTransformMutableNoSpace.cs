#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugTransform.h")]
///<summary>Given a transform, will draw a point, axis, or a box in the viewport</summary>
public partial struct FRigVMFunction_DebugTransformMutableNoSpace {
// RigVMFunction_DebugTransformMutableNoSpace
	public FTransform Transform;
	public ERigUnitDebugTransformMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public FTransform WorldOffset;
	public bool bEnabled;
}
