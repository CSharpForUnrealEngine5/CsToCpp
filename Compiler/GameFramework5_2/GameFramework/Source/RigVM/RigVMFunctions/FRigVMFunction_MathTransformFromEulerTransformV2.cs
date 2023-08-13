namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a quaternion based transform from a euler based transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformFromEulerTransformV2 {
	public FEulerTransform Value;
	public FTransform Result;
}
