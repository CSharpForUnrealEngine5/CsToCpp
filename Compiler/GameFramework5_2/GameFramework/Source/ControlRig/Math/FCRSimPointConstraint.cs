#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Math/Simulation/CRSimPointConstraint.h")]
public partial struct FCRSimPointConstraint {
// CRSimPointConstraint
	public ECRSimConstraintType Type;
	public int SubjectA;
	public int SubjectB;
	public FVector DataA;
	public FVector DataB;
}
