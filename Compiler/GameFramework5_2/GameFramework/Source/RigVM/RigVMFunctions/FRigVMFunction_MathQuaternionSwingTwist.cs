#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
///<summary>Computes the swing and twist components of a quaternion</summary>
public partial struct FRigVMFunction_MathQuaternionSwingTwist {
// RigVMFunction_MathQuaternionSwingTwist
	public FQuat Input;
	public FVector TwistAxis;
	public FQuat Swing;
	public FQuat Twist;
}
