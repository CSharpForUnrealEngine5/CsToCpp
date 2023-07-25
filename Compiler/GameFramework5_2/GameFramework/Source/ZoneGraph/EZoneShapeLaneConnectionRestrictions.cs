#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public enum EZoneShapeLaneConnectionRestrictions {
	None=0,
	NoLeftTurn=-1,
	NoRightTurn=-1,
	OneLanePerDestination=-1,
	MergeLanesToOneDestinationLane=-1,
}
