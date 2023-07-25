#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugLineStrip.h")]
///<summary>Draws a line strip in the viewport given any number of points</summary>
public partial struct FRigVMFunction_DebugLineStripNoSpace {
// RigVMFunction_DebugLineStripNoSpace
	public TArray<FVector> Points;
	public FLinearColor Color;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
