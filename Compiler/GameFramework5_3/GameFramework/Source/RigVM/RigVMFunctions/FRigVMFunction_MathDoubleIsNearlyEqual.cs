namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if the value A is almost equal to B</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathDouble.h")]
public partial struct FRigVMFunction_MathDoubleIsNearlyEqual {
	public double A;
	public double B;
	public double Tolerance;
	public bool Result;
}
