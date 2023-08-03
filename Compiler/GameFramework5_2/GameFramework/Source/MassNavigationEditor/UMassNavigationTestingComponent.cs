#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component for testing MassMovement functionality.</summary>
[CppInclude("MassNavigationTestingActor.h")]
public partial class UMassNavigationTestingComponent : UDebugDrawComponent {
	public static UClass StaticClass() {return default;}
	///<summary>ZoneGraph</summary>
	public UZoneGraphSubsystem ZoneGraph;
	///<summary>LaneLocation</summary>
	public FZoneGraphLaneLocation LaneLocation;
	///<summary>GoalLaneLocation</summary>
	public FZoneGraphLaneLocation GoalLaneLocation;
	///<summary>SearchExtent</summary>
	public FVector SearchExtent;
	///<summary>AnticipationDistance</summary>
	public float AnticipationDistance;
	///<summary>AgentRadius</summary>
	public float AgentRadius;
	///<summary>bHasSpecificEndPoint</summary>
	public bool bHasSpecificEndPoint;
	///<summary>QueryFilter</summary>
	public FZoneGraphTagFilter QueryFilter;
	///<summary>GoalPosition</summary>
	public FVector GoalPosition;
}
