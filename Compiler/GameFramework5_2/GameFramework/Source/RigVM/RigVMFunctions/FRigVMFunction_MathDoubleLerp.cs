#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly interpolates between A and B using the ratio T</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathDouble.h")]
public partial struct FRigVMFunction_MathDoubleLerp {
	public double A;
	public double B;
	public double T;
	public double Result;
}
