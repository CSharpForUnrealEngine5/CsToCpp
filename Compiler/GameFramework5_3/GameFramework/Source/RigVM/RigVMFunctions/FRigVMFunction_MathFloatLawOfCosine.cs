namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes the angles alpha, beta and gamma (in radians) between the three sides A, B and C</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathFloat.h")]
public partial struct FRigVMFunction_MathFloatLawOfCosine {
	public float A;
	public float B;
	public float C;
	public float AlphaAngle;
	public float BetaAngle;
	public float GammaAngle;
	public bool bValid;
}
