#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Returns the relative local transform within a parent's transform</summary>
public partial struct FRigVMFunction_MathTransformMakeRelative {
// RigVMFunction_MathTransformMakeRelative
	public FTransform Global;
	public FTransform Parent;
	public FTransform Local;
}
