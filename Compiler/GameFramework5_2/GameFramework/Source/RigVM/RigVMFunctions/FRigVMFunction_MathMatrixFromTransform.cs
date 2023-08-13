namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a matrix from a transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathMatrix.h")]
public partial struct FRigVMFunction_MathMatrixFromTransform {
	public FTransform Transform;
	public FMatrix Result;
}
