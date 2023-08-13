namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug draw parameters for a Point or Vector given a vector</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_VisualDebug.h")]
public partial struct FRigVMFunction_VisualDebugVectorNoSpace {
	public FVector Value;
	public bool bEnabled;
	public ERigUnitVisualDebugPointMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
}
