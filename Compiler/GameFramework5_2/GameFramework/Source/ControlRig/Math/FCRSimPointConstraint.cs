namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Math/Simulation/CRSimPointConstraint.h")]
public partial struct FCRSimPointConstraint {
	public ECRSimConstraintType Type;
	public int SubjectA;
	public int SubjectB;
	public FVector DataA;
	public FVector DataB;
}
