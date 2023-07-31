#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosSolverActor.h")]
public partial class AChaosSolverActor : AActor {
	///<summary>Properties</summary>
	public FChaosSolverConfiguration Properties;
	///<summary>Deprecated solver properties (moved to FChaosSolverConfiguration)</summary>
	public float TimeStepMultiplier_DEPRECATED;
	///<summary>CollisionIterations_DEPRECATED</summary>
	public int CollisionIterations_DEPRECATED;
	///<summary>PushOutIterations_DEPRECATED</summary>
	public int PushOutIterations_DEPRECATED;
	///<summary>PushOutPairIterations_DEPRECATED</summary>
	public int PushOutPairIterations_DEPRECATED;
	///<summary>ClusterConnectionFactor_DEPRECATED</summary>
	public float ClusterConnectionFactor_DEPRECATED;
	///<summary>ClusterUnionConnectionType_DEPRECATED</summary>
	public EClusterConnectionTypeEnum ClusterUnionConnectionType_DEPRECATED;
	///<summary>DoGenerateCollisionData_DEPRECATED</summary>
	public bool DoGenerateCollisionData_DEPRECATED;
	///<summary>CollisionFilterSettings_DEPRECATED</summary>
	public FSolverCollisionFilterSettings CollisionFilterSettings_DEPRECATED;
	///<summary>DoGenerateBreakingData_DEPRECATED</summary>
	public bool DoGenerateBreakingData_DEPRECATED;
	///<summary>BreakingFilterSettings_DEPRECATED</summary>
	public FSolverBreakingFilterSettings BreakingFilterSettings_DEPRECATED;
	///<summary>DoGenerateTrailingData_DEPRECATED</summary>
	public bool DoGenerateTrailingData_DEPRECATED;
	///<summary>TrailingFilterSettings_DEPRECATED</summary>
	public FSolverTrailingFilterSettings TrailingFilterSettings_DEPRECATED;
	///<summary>MassScale_DEPRECATED</summary>
	public float MassScale_DEPRECATED;
	///<summary>End deprecated properties</summary>
	public bool bHasFloor;
	///<summary>FloorHeight</summary>
	public float FloorHeight;
	///<summary>* Control to pause/step/substep the solver to the next synchronization point.</summary>
	public FChaosDebugSubstepControl ChaosDebugSubstepControl;
	///<summary>Makes this solver the current world solver. Dynamically spawned objects will have their physics state created in this solver.</summary>
	public  void SetAsCurrentWorldSolver() {}
	///<summary>Controls whether the solver is able to simulate particles it controls</summary>
	public  void SetSolverActive(bool bActive) {}
	///<summary>* Display icon in the editor</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>Component responsible for harvesting and triggering physics-related gameplay events (hits, breaks, etc)</summary>
	public UChaosGameplayEventDispatcher GameplayEventDispatcherComponent;
}
