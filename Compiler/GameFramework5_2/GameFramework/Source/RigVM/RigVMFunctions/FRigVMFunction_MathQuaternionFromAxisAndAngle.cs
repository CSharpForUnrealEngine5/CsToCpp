#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a quaternion from an axis and an angle in radians</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionFromAxisAndAngle {
	public FVector Axis;
	public float Angle;
	public FQuat Result;
}
