#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
///<summary>Mirror a rotation about a central transform.</summary>
public partial struct FRigVMFunction_MathQuaternionMirrorTransform {
// RigVMFunction_MathQuaternionMirrorTransform
	public FQuat Value;
	public byte MirrorAxis;
	public byte AxisToFlip;
	public FTransform CentralTransform;
	public FQuat Result;
}
