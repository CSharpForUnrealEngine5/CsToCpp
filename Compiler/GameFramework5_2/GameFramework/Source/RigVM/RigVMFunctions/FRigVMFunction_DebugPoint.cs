namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugPoint.h")]
public partial struct FRigVMFunction_DebugPoint {
	public FVector Vector;
	public ERigUnitDebugPointMode Mode;
	public FLinearColor Color;
	public float Scale;
	public float Thickness;
	public string Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
