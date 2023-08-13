namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Makes a matrix from its vectors</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathMatrix.h")]
public partial struct FRigVMFunction_MathMatrixFromVectors {
	public FVector Origin;
	public FVector X;
	public FVector Y;
	public FVector Z;
	public FMatrix Result;
}
