namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a quaternion from a rotator</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionFromRotatorV2 {
	public FRotator Value;
	public FQuat Result;
}
