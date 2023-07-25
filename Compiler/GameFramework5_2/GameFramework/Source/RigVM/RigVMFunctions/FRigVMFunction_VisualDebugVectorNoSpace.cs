#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_VisualDebug.h")]
///<summary>Debug draw parameters for a Point or Vector given a vector</summary>
public partial struct FRigVMFunction_VisualDebugVectorNoSpace {
// RigVMFunction_VisualDebugVectorNoSpace
	public FVector Value;
	public bool bEnabled;
	public ERigUnitVisualDebugPointMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
}
