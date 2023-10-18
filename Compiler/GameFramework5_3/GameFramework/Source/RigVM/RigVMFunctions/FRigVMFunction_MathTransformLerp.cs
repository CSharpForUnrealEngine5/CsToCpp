namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly interpolates between A and B using the ratio T</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformLerp {
	public FTransform A;
	public FTransform B;
	public float T;
	public FTransform Result;
}
