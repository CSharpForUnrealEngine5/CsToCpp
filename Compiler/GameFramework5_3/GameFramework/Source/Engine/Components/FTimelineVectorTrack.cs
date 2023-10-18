namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
[CppInclude("Components/TimelineComponent.h")]
public partial struct FTimelineVectorTrack {
	public UCurveVector VectorCurve;
	public FOnTimelineVector InterpFunc;
	public FName TrackName;
	public FName VectorPropertyName;
}
