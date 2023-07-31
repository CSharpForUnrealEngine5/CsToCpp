#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a matrix from a transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathMatrix.h")]
public partial struct FRigVMFunction_MathMatrixFromTransform {
	public FTransform Transform;
	public FMatrix Result;
}
