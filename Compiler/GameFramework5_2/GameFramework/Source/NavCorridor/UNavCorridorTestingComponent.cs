#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component for testing AI Locomotion functionality.</summary>
[CppInclude("NavCorridorTestingComponent.h")]
public partial class UNavCorridorTestingComponent : UDebugDrawComponent {
	///<summary>NavAgentProps</summary>
	public FNavAgentProperties NavAgentProps;
	///<summary>FilterClass</summary>
	public UClass FilterClass;
	///<summary>If true, finds path to Goal actor.</summary>
	public bool bFindCorridorToGoal;
	///<summary>If true, finds nearest path location on Goal actor corridor.</summary>
	public bool bFollowPathOnGoalCorridor;
	///<summary>FollowLookAheadDistance</summary>
	public float FollowLookAheadDistance;
	///<summary>GoalActor</summary>
	public AActor GoalActor;
	///<summary>NavData</summary>
	public ANavigationData NavData;
	///<summary>CorridorParams</summary>
	public FNavCorridorParams CorridorParams;
	///<summary>bUpdateParametersFromWidth</summary>
	public bool bUpdateParametersFromWidth;
	///<summary>PathOffset</summary>
	public float PathOffset;
	///<summary>PathfindingTimeUs</summary>
	public float PathfindingTimeUs;
	///<summary>CorridorTimeUs</summary>
	public float CorridorTimeUs;
}
