namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly interpolates between A and B using the ratio T</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorLerp {
	public FVector A;
	public FVector B;
	public float T;
	public FVector Result;
}
