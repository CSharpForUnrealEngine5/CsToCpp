namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that contains one entry for an &#39;event&#39; during the timeline</summary>
[CppInclude("Components/TimelineComponent.h")]
public partial struct FTimelineEventEntry {
	public float Time;
	public FOnTimelineEvent EventFunc;
}
