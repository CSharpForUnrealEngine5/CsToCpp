#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
///<summary>Makes a quaternion from euler values in degrees</summary>
public partial struct FRigVMFunction_MathQuaternionFromEuler {
// RigVMFunction_MathQuaternionFromEuler
	public FVector Euler;
	public EEulerRotationOrder RotationOrder;
	public FQuat Result;
}
