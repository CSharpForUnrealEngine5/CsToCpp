namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Return one of the two values based on the condition</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformSelectBool {
	public bool Condition;
	public FTransform IfTrue;
	public FTransform IfFalse;
	public FTransform Result;
}
