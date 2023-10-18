namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Debug/RigUnit_DebugTransform.h")]
public partial struct FRigUnit_DebugTransform {
	public FTransform Transform;
	public ERigUnitDebugTransformMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public FName Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
