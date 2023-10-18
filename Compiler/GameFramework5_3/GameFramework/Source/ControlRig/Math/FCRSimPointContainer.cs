namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Math/Simulation/CRSimPointContainer.h")]
public partial struct FCRSimPointContainer {
	public TArray<FRigVMSimPoint> Points;
	public TArray<FCRSimLinearSpring> Springs;
	public TArray<FCRSimPointForce> Forces;
	public TArray<FCRSimSoftCollision> CollisionVolumes;
	public TArray<FCRSimPointConstraint> Constraints;
	public TArray<FRigVMSimPoint> PreviousStep;
}
