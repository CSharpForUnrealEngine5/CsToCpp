#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Return one of the two values based on the condition</summary>
public partial struct FRigVMFunction_MathVectorSelectBool {
// RigVMFunction_MathVectorSelectBool
	public bool Condition;
	public FVector IfTrue;
	public FVector IfFalse;
	public FVector Result;
}
