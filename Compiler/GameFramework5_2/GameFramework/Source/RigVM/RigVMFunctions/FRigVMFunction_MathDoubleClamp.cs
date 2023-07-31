#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps the given value within the range provided by minimum and maximum</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathDouble.h")]
public partial struct FRigVMFunction_MathDoubleClamp {
	public double Value;
	public double Minimum;
	public double Maximum;
	public double Result;
}
