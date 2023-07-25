#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavCorridorTestingComponent.h")]
///<summary>Component for testing AI Locomotion functionality.</summary>
public partial class UNavCorridorTestingComponent : UDebugDrawComponent {
// NavCorridorTestingComponent
	public FNavAgentProperties NavAgentProps;
	public UClass FilterClass;
	public bool bFindCorridorToGoal;
	public bool bFollowPathOnGoalCorridor;
	public float FollowLookAheadDistance;
	public AActor GoalActor;
	public ANavigationData NavData;
	public FNavCorridorParams CorridorParams;
	public bool bUpdateParametersFromWidth;
	public float PathOffset;
	public float PathfindingTimeUs;
	public float CorridorTimeUs;
}
