namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a quaternion from its components</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionMake {
	public float X;
	public float Y;
	public float Z;
	public float W;
	public FQuat Result;
}
