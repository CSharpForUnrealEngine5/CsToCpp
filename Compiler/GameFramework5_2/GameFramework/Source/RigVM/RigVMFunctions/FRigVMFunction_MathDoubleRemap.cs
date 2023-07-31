#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remaps the given value from a source range to a target range.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathDouble.h")]
public partial struct FRigVMFunction_MathDoubleRemap {
	public double Value;
	public double SourceMinimum;
	public double SourceMaximum;
	public double TargetMinimum;
	public double TargetMaximum;
	public bool bClamp;
	public double Result;
}
