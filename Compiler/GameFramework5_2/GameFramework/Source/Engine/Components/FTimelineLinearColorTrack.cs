namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that contains one entry for each linear color interpolation performed by the timeline</summary>
[CppInclude("Components/TimelineComponent.h")]
public partial struct FTimelineLinearColorTrack {
	public UCurveLinearColor LinearColorCurve;
	public FOnTimelineLinearColor InterpFunc;
	public string TrackName;
	public string LinearColorPropertyName;
}
