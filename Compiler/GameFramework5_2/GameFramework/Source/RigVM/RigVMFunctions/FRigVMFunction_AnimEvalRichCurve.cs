#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Animation/RigVMFunction_AnimEvalRichCurve.h")]
///<summary>Evaluates the provided curve. Values are normalized between 0 and 1</summary>
public partial struct FRigVMFunction_AnimEvalRichCurve {
// RigVMFunction_AnimEvalRichCurve
	public float Value;
	public FRuntimeFloatCurve Curve;
	public float SourceMinimum;
	public float SourceMaximum;
	public float TargetMinimum;
	public float TargetMaximum;
	public float Result;
}
