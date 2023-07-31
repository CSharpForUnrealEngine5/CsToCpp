#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
[CppInclude("Components/TimelineComponent.h")]
public partial struct FTimelineFloatTrack {
	public UCurveFloat FloatCurve;
	public FOnTimelineFloat InterpFunc;
	public string TrackName;
	public string FloatPropertyName;
}
