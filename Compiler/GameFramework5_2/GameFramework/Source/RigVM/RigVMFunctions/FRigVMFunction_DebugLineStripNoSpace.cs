#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws a line strip in the viewport given any number of points</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugLineStrip.h")]
public partial struct FRigVMFunction_DebugLineStripNoSpace {
	public TArray<FVector> Points;
	public FLinearColor Color;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
