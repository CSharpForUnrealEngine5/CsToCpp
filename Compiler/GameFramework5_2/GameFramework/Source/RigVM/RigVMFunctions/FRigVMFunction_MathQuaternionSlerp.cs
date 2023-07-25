#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
///<summary>Linearly interpolates between A and B using the ratio T</summary>
public partial struct FRigVMFunction_MathQuaternionSlerp {
// RigVMFunction_MathQuaternionSlerp
	public FQuat A;
	public FQuat B;
	public float T;
	public FQuat Result;
}
