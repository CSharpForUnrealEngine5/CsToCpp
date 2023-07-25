#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphCrowdLaneAnnotations.h")]
///<summary>Event indicating the new state of a lane.</summary>
public partial struct FZoneGraphCrowdLaneStateChangeEvent {
// ZoneGraphCrowdLaneStateChangeEvent
	public FZoneGraphLaneHandle Lane;
	public ECrowdLaneState State;
}
