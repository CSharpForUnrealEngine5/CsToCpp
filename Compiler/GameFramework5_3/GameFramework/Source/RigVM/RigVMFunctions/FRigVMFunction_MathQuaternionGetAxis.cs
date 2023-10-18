namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rotates a given vector by the quaternion</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionGetAxis {
	public FQuat Quaternion;
	public EAxis Axis;
	public FVector Result;
}
