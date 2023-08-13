namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if the two vectors are orthogonal</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorOrthogonal {
	public FVector A;
	public FVector B;
	public bool Result;
}
