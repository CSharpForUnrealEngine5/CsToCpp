namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if the value A is almost equal to B</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathFloat.h")]
public partial struct FRigVMFunction_MathFloatIsNearlyEqual {
	public float A;
	public float B;
	public float Tolerance;
	public bool Result;
}
