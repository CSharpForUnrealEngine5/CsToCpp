namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps the given value within the range provided by minimum and maximum</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathInt.h")]
public partial struct FRigVMFunction_MathIntClamp {
	public int Value;
	public int Minimum;
	public int Maximum;
	public int Result;
}
