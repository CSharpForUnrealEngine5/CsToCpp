#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
///<summary>Whether or not the timeline should be finished after the specified length, or the last keyframe in the tracks</summary>
public enum ETimelineLengthMode {
	TL_TimelineLength=0,
	TL_LastKeyFrame=1,
}
