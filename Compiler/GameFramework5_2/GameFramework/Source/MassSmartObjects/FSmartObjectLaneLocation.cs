namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to keep track of a SmartObject entry point on a given lane.</summary>
[CppInclude("SmartObjectZoneAnnotations.h")]
public partial struct FSmartObjectLaneLocation {
	public FSmartObjectHandle ObjectHandle;
	public int LaneIndex;
	public float DistanceAlongLane;
}
