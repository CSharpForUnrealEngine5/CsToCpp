#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Linearly interpolates between A and B using the ratio T</summary>
public partial struct FRigVMFunction_MathTransformLerp {
// RigVMFunction_MathTransformLerp
	public FTransform A;
	public FTransform B;
	public float T;
	public FTransform Result;
}
