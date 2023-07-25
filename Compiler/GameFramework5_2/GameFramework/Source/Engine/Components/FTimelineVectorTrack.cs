#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
///<summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
public partial struct FTimelineVectorTrack {
// TimelineVectorTrack
	public UCurveVector VectorCurve;
	public FOnTimelineVector InterpFunc;
	public string TrackName;
	public string VectorPropertyName;
}
