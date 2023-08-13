namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a transform from a matrix</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathMatrix.h")]
public partial struct FRigVMFunction_MathMatrixToTransform {
	public FMatrix Value;
	public FTransform Result;
}
