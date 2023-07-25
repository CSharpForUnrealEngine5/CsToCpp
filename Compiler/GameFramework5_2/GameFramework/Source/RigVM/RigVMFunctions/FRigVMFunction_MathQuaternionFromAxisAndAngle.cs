#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
///<summary>Makes a quaternion from an axis and an angle in radians</summary>
public partial struct FRigVMFunction_MathQuaternionFromAxisAndAngle {
// RigVMFunction_MathQuaternionFromAxisAndAngle
	public FVector Axis;
	public float Angle;
	public FQuat Result;
}
