#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphLaneLocation {
// ZoneGraphLaneLocation
	public FVector Position;
	public FVector Direction;
	public FVector Tangent;
	public FVector Up;
	public FZoneGraphLaneHandle LaneHandle;
	public int LaneSegment;
	public float DistanceAlongLane;
}
