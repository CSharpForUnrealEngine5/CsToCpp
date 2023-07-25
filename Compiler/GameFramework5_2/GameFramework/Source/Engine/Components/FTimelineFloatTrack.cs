#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
///<summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
public partial struct FTimelineFloatTrack {
// TimelineFloatTrack
	public UCurveFloat FloatCurve;
	public FOnTimelineFloat InterpFunc;
	public string TrackName;
	public string FloatPropertyName;
}
