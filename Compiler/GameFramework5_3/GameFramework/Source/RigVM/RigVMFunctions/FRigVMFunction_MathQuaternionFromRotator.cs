namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a quaternion from a rotator</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionFromRotator {
	public FRotator Rotator;
	public FQuat Result;
}
