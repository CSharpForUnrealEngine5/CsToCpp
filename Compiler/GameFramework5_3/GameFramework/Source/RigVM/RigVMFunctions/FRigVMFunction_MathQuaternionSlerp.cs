namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly interpolates between A and B using the ratio T</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionSlerp {
	public FQuat A;
	public FQuat B;
	public float T;
	public FQuat Result;
}
