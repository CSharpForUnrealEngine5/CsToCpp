namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the product of the the vector and the float value</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorScale {
	public FVector Value;
	public float Factor;
	public FVector Result;
}
