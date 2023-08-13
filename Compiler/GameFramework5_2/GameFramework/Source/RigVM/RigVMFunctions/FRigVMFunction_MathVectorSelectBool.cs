namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Return one of the two values based on the condition</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorSelectBool {
	public bool Condition;
	public FVector IfTrue;
	public FVector IfFalse;
	public FVector Result;
}
