namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Return one of the two values based on the condition</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionSelectBool {
	public bool Condition;
	public FQuat IfTrue;
	public FQuat IfFalse;
	public FQuat Result;
}
