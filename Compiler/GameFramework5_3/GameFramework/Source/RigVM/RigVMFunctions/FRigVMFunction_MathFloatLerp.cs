namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly interpolates between A and B using the ratio T</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathFloat.h")]
public partial struct FRigVMFunction_MathFloatLerp {
	public float A;
	public float B;
	public float T;
	public float Result;
}
