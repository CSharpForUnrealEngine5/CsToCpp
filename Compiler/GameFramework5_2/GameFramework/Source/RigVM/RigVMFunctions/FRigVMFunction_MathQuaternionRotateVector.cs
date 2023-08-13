namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rotates a given vector by the quaternion</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionRotateVector {
	public FQuat Transform;
	public FVector Vector;
	public FVector Result;
}
