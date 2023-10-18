namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event indicating the new state of a lane.</summary>
[CppInclude("ZoneGraphCrowdLaneAnnotations.h")]
public partial struct FZoneGraphCrowdLaneStateChangeEvent {
	public FZoneGraphLaneHandle Lane;
	public ECrowdLaneState State;
}
