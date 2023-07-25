#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Return one of the two values based on the condition</summary>
public partial struct FRigVMFunction_MathTransformSelectBool {
// RigVMFunction_MathTransformSelectBool
	public bool Condition;
	public FTransform IfTrue;
	public FTransform IfFalse;
	public FTransform Result;
}
