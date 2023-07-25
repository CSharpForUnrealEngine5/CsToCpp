#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Math/Simulation/CRSimPointContainer.h")]
public partial struct FCRSimPointContainer {
// CRSimPointContainer
	public TArray<FRigVMSimPoint> Points;
	public TArray<FCRSimLinearSpring> Springs;
	public TArray<FCRSimPointForce> Forces;
	public TArray<FCRSimSoftCollision> CollisionVolumes;
	public TArray<FCRSimPointConstraint> Constraints;
	public TArray<FRigVMSimPoint> PreviousStep;
}
