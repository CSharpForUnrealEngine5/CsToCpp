#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Simulation/RigUnit_PointSimulation.h")]
///<summary>Performs point based simulation</summary>
public partial struct FRigUnit_PointSimulation {
// RigUnit_PointSimulation
	public TArray<FRigVMSimPoint> Points;
	public TArray<FCRSimLinearSpring> Links;
	public TArray<FCRSimPointForce> Forces;
	public TArray<FCRSimSoftCollision> CollisionVolumes;
	public float SimulatedStepsPerSecond;
	public ERigVMSimPointIntegrateType IntegratorType;
	public float VerletBlend;
	public TArray<FRigUnit_PointSimulation_BoneTarget> BoneTargets;
	public bool bLimitLocalPosition;
	public bool bPropagateToChildren;
	public FVector PrimaryAimAxis;
	public FVector SecondaryAimAxis;
	public FRigUnit_PointSimulation_DebugSettings DebugSettings;
	public FRigVMFourPointBezier Bezier;
	public FRigUnit_PointSimulation_WorkData WorkData;
}
