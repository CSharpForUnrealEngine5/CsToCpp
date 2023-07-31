#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the eased version of the input value</summary>
[CppInclude("RigVMFunctions/Animation/RigVMFunction_AnimEasing.h")]
public partial struct FRigVMFunction_AnimEasing {
	public float Value;
	public ERigVMAnimEasingType Type;
	public float SourceMinimum;
	public float SourceMaximum;
	public float TargetMinimum;
	public float TargetMaximum;
	public float Result;
}
