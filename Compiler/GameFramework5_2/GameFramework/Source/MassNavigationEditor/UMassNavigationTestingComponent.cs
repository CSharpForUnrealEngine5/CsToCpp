#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassNavigationTestingActor.h")]
///<summary>Component for testing MassMovement functionality.</summary>
public partial class UMassNavigationTestingComponent : UDebugDrawComponent {
// MassNavigationTestingComponent
	public UZoneGraphSubsystem ZoneGraph;
	public FZoneGraphLaneLocation LaneLocation;
	public FZoneGraphLaneLocation GoalLaneLocation;
	public FVector SearchExtent;
	public float AnticipationDistance;
	public float AgentRadius;
	public bool bHasSpecificEndPoint;
	public FZoneGraphTagFilter QueryFilter;
	public FVector GoalPosition;
}
