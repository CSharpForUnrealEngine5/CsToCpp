#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugLine.h")]
///<summary>Draws a line in the viewport given a start and end vector</summary>
public partial struct FRigVMFunction_DebugLineNoSpace {
// RigVMFunction_DebugLineNoSpace
	public FVector A;
	public FVector B;
	public FLinearColor Color;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
