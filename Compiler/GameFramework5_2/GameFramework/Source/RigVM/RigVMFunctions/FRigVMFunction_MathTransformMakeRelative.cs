namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the relative local transform within a parent&#39;s transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformMakeRelative {
	public FTransform Global;
	public FTransform Parent;
	public FTransform Local;
}
