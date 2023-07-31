#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Retrieves a euler based transform from a quaternion based transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformToEulerTransform {
	public FTransform Value;
	public FEulerTransform Result;
}
