namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if the value is nearly zero</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorIsNearlyZero {
	public FVector Value;
	public float Tolerance;
	public bool Result;
}
