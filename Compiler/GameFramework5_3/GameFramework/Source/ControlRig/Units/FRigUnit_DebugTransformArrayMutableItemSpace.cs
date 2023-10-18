namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a transform array, will draw a point, axis, or a box in the viewport</summary>
[CppInclude("Units/Debug/RigUnit_DebugTransform.h")]
public partial struct FRigUnit_DebugTransformArrayMutableItemSpace {
	public TArray<FTransform> Transforms;
	public TArray<int> ParentIndices;
	public ERigUnitDebugTransformMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public FRigElementKey Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
