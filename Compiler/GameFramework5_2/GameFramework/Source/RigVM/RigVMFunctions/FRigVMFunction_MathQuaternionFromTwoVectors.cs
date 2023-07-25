#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
///<summary>Makes a quaternion from two vectors, representing the shortest rotation between the two vectors.</summary>
public partial struct FRigVMFunction_MathQuaternionFromTwoVectors {
// RigVMFunction_MathQuaternionFromTwoVectors
	public FVector A;
	public FVector B;
	public FQuat Result;
}
