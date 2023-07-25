#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectZoneAnnotations.h")]
///<summary>Struct to keep track of a SmartObject entry point on a given lane.</summary>
public partial struct FSmartObjectLaneLocation {
// SmartObjectLaneLocation
	public FSmartObjectHandle ObjectHandle;
	public int LaneIndex;
	public float DistanceAlongLane;
}
