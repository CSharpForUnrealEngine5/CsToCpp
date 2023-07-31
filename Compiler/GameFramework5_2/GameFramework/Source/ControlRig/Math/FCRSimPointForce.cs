#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Math/Simulation/CRSimPointForce.h")]
public partial struct FCRSimPointForce {
	public ECRSimPointForceType ForceType;
	public FVector Vector;
	public float Coefficient;
	public bool bNormalize;
}
