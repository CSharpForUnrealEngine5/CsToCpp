#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Animation/RigVMFunction_AnimEasing.h")]
///<summary>Returns the eased version of the input value</summary>
public partial struct FRigVMFunction_AnimEasing {
// RigVMFunction_AnimEasing
	public float Value;
	public ERigVMAnimEasingType Type;
	public float SourceMinimum;
	public float SourceMaximum;
	public float TargetMinimum;
	public float TargetMaximum;
	public float Result;
}
