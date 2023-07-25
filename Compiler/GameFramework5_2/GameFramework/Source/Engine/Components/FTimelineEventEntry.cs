#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
///<summary>Struct that contains one entry for an 'event' during the timeline</summary>
public partial struct FTimelineEventEntry {
// TimelineEventEntry
	public float Time;
	public FOnTimelineEvent EventFunc;
}
