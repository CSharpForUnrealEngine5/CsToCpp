namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Retrieves the axis and angle of a quaternion in radians</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionToAxisAndAngle {
	public FQuat Value;
	public FVector Axis;
	public float Angle;
}
