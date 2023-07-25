#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathFloat.h")]
///<summary>Return one of the two values based on the condition</summary>
public partial struct FRigVMFunction_MathFloatSelectBool {
// RigVMFunction_MathFloatSelectBool
	public bool Condition;
	public float IfTrue;
	public float IfFalse;
	public float Result;
}
