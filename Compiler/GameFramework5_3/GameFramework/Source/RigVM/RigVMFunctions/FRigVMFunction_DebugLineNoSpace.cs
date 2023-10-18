namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws a line in the viewport given a start and end vector</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugLine.h")]
public partial struct FRigVMFunction_DebugLineNoSpace {
	public FVector A;
	public FVector B;
	public FLinearColor Color;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
