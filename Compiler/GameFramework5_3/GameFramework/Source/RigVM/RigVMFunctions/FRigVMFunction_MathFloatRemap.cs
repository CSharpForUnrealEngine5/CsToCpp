namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remaps the given value from a source range to a target range.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathFloat.h")]
public partial struct FRigVMFunction_MathFloatRemap {
	public float Value;
	public float SourceMinimum;
	public float SourceMaximum;
	public float TargetMinimum;
	public float TargetMaximum;
	public bool bClamp;
	public float Result;
}
