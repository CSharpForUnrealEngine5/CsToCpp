#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplinesComponent.h")]
public partial struct FForeignWorldSplineData {
	public TMap<TLazyObjectPtr<ULandscapeSplineControlPoint>,FForeignControlPointData> ForeignControlPointDataMap_DEPRECATED;
	public TArray<FForeignControlPointData> ForeignControlPointData;
	public TMap<TLazyObjectPtr<ULandscapeSplineSegment>,FForeignSplineSegmentData> ForeignSplineSegmentDataMap_DEPRECATED;
	public TArray<FForeignSplineSegmentData> ForeignSplineSegmentData;
}
