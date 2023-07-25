#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathDouble.h")]
///<summary>Remaps the given value from a source range to a target range.</summary>
public partial struct FRigVMFunction_MathDoubleRemap {
// RigVMFunction_MathDoubleRemap
	public double Value;
	public double SourceMinimum;
	public double SourceMaximum;
	public double TargetMinimum;
	public double TargetMaximum;
	public bool bClamp;
	public double Result;
}
