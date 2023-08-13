namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the absolute global transform within a parent&#39;s transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformMakeAbsolute {
	public FTransform Local;
	public FTransform Parent;
	public FTransform Global;
}
