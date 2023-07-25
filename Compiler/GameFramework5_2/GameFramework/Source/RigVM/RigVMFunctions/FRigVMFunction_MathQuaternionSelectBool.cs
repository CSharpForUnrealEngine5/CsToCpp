#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
///<summary>Return one of the two values based on the condition</summary>
public partial struct FRigVMFunction_MathQuaternionSelectBool {
// RigVMFunction_MathQuaternionSelectBool
	public bool Condition;
	public FQuat IfTrue;
	public FQuat IfFalse;
	public FQuat Result;
}
