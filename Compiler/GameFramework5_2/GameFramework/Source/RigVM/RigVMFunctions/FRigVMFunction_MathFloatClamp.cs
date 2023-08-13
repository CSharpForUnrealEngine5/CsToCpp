namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps the given value within the range provided by minimum and maximum</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathFloat.h")]
public partial struct FRigVMFunction_MathFloatClamp {
	public float Value;
	public float Minimum;
	public float Maximum;
	public float Result;
}
