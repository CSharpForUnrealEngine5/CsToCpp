namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if the value A is almost equal to B</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorIsNearlyEqual {
	public FVector A;
	public FVector B;
	public float Tolerance;
	public bool Result;
}
