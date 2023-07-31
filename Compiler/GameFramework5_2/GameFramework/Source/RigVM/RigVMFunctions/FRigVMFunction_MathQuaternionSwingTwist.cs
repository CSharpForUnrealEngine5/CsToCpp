#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes the swing and twist components of a quaternion</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionSwingTwist {
	public FQuat Input;
	public FVector TwistAxis;
	public FQuat Swing;
	public FQuat Twist;
}
