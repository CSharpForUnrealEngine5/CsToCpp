#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosSolverActor.h")]
public partial class AChaosSolverActor : AActor {
// ChaosSolverActor
	public FChaosSolverConfiguration Properties;
	public float TimeStepMultiplier_DEPRECATED;
	public int CollisionIterations_DEPRECATED;
	public int PushOutIterations_DEPRECATED;
	public int PushOutPairIterations_DEPRECATED;
	public float ClusterConnectionFactor_DEPRECATED;
	public EClusterConnectionTypeEnum ClusterUnionConnectionType_DEPRECATED;
	public bool DoGenerateCollisionData_DEPRECATED;
	public FSolverCollisionFilterSettings CollisionFilterSettings_DEPRECATED;
	public bool DoGenerateBreakingData_DEPRECATED;
	public FSolverBreakingFilterSettings BreakingFilterSettings_DEPRECATED;
	public bool DoGenerateTrailingData_DEPRECATED;
	public FSolverTrailingFilterSettings TrailingFilterSettings_DEPRECATED;
	public float MassScale_DEPRECATED;
	public bool bHasFloor;
	public float FloorHeight;
	public FChaosDebugSubstepControl ChaosDebugSubstepControl;
	public  void SetAsCurrentWorldSolver() {}
	public  void SetSolverActive(bool bActive) {}
	public UBillboardComponent SpriteComponent;
	public UChaosGameplayEventDispatcher GameplayEventDispatcherComponent;
}
