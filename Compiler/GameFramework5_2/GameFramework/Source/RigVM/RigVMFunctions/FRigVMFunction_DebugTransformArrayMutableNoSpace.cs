#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a transform array, will draw a point, axis, or a box in the viewport</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugTransform.h")]
public partial struct FRigVMFunction_DebugTransformArrayMutableNoSpace {
	public TArray<FTransform> Transforms;
	public TArray<int> ParentIndices;
	public ERigUnitDebugTransformMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public FTransform WorldOffset;
	public bool bEnabled;
}
