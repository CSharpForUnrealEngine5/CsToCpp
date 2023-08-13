namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the dot product between two quaternions</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionDot {
	public FQuat A;
	public FQuat B;
	public float Result;
}
