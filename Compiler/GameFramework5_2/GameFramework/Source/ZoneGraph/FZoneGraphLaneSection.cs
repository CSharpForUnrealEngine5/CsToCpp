namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Section of a lane</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphLaneSection {
	public FZoneGraphLaneHandle LaneHandle;
	public float StartDistanceAlongLane;
	public float EndDistanceAlongLane;
}
