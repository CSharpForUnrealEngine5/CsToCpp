namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a quaternion from two vectors, representing the shortest rotation between the two vectors.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionFromTwoVectors {
	public FVector A;
	public FVector B;
	public FQuat Result;
}
