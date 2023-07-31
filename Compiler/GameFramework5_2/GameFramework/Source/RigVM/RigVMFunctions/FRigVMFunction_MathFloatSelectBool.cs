#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Return one of the two values based on the condition</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathFloat.h")]
public partial struct FRigVMFunction_MathFloatSelectBool {
	public bool Condition;
	public float IfTrue;
	public float IfFalse;
	public float Result;
}
