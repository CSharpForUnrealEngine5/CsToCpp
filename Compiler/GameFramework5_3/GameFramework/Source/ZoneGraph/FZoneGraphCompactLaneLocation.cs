namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Minimal amount of data to search and compare lane location.</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphCompactLaneLocation {
	public FZoneGraphLaneHandle LaneHandle;
	public float DistanceAlongLane;
}
