namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts the matrix to its vectors</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathMatrix.h")]
public partial struct FRigVMFunction_MathMatrixToVectors {
	public FMatrix Value;
	public FVector Origin;
	public FVector X;
	public FVector Y;
	public FVector Z;
}
