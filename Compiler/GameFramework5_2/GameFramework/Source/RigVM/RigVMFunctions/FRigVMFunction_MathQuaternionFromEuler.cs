#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a quaternion from euler values in degrees</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionFromEuler {
	public FVector Euler;
	public EEulerRotationOrder RotationOrder;
	public FQuat Result;
}
