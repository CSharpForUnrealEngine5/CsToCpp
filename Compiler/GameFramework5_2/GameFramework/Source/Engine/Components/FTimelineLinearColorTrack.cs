#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
///<summary>Struct that contains one entry for each linear color interpolation performed by the timeline</summary>
public partial struct FTimelineLinearColorTrack {
// TimelineLinearColorTrack
	public UCurveLinearColor LinearColorCurve;
	public FOnTimelineLinearColor InterpFunc;
	public string TrackName;
	public string LinearColorPropertyName;
}
