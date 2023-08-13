namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluates the provided curve. Values are normalized between 0 and 1</summary>
[CppInclude("RigVMFunctions/Animation/RigVMFunction_AnimEvalRichCurve.h")]
public partial struct FRigVMFunction_AnimEvalRichCurve {
	public float Value;
	public FRuntimeFloatCurve Curve;
	public float SourceMinimum;
	public float SourceMaximum;
	public float TargetMinimum;
	public float TargetMaximum;
	public float Result;
}
