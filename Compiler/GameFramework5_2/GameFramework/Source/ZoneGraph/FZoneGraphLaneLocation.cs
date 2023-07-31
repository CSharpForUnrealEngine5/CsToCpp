#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphLaneLocation {
	public FVector Position;
	public FVector Direction;
	public FVector Tangent;
	public FVector Up;
	public FZoneGraphLaneHandle LaneHandle;
	public int LaneSegment;
	public float DistanceAlongLane;
}
