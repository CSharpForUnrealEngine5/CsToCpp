namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the relative local transform within a parent&#39;s transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathQuaternion.h")]
public partial struct FRigVMFunction_MathQuaternionMakeRelative {
	public FQuat Global;
	public FQuat Parent;
	public FQuat Local;
}
