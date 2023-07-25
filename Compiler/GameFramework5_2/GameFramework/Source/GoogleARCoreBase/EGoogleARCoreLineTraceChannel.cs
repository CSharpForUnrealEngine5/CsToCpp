#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreTypes.h")]
///<summary>@ingroup GoogleARCoreBase</summary>
public enum EGoogleARCoreLineTraceChannel {
	None=0,
	FeaturePoint=1,
	InfinitePlane=2,
	PlaneUsingExtent=4,
	PlaneUsingBoundaryPolygon=8,
	FeaturePointWithSurfaceNormal=16,
	AugmentedImage=32,
}
