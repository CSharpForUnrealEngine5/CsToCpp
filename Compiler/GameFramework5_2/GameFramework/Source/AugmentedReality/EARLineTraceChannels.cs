#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>Channels that let users select which kind of tracked geometry to trace against.</summary>
public enum EARLineTraceChannels {
	None=0,
	FeaturePoint=1,
	GroundPlane=2,
	PlaneUsingExtent=4,
	PlaneUsingBoundaryPolygon=8,
}
