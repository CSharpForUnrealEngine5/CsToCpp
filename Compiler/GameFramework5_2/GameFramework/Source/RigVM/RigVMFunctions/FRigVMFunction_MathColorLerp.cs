#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathColor.h")]
///<summary>Linearly interpolates between A and B using the ratio T</summary>
public partial struct FRigVMFunction_MathColorLerp {
// RigVMFunction_MathColorLerp
	public FLinearColor A;
	public FLinearColor B;
	public float T;
	public FLinearColor Result;
}
