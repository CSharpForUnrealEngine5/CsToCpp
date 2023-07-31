#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Controls behavior of WalkableSlopeOverride, determining how to affect walkability of surfaces for Characters.</summary>
public enum EWalkableSlopeBehavior {
	WalkableSlope_Default=0,
	WalkableSlope_Increase=1,
	WalkableSlope_Decrease=2,
	WalkableSlope_Unwalkable=3,
	WalkableSlope_Max=4,
}
