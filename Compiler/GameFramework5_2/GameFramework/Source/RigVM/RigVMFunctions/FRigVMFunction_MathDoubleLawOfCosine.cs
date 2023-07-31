#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes the angles alpha, beta and gamma (in radians) between the three sides A, B and C</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathDouble.h")]
public partial struct FRigVMFunction_MathDoubleLawOfCosine {
	public double A;
	public double B;
	public double C;
	public double AlphaAngle;
	public double BetaAngle;
	public double GammaAngle;
	public bool bValid;
}
