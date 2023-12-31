namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly interpolates between A and B using the ratio T</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathColor.h")]
public partial struct FRigVMFunction_MathColorLerp {
	public FLinearColor A;
	public FLinearColor B;
	public float T;
	public FLinearColor Result;
}
