#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplinesComponent.h")]
public partial struct FForeignWorldSplineData {
// ForeignWorldSplineData
	public TMap<TLazyObjectPtr<ULandscapeSplineControlPoint>,FForeignControlPointData> ForeignControlPointDataMap_DEPRECATED;
	public TArray<FForeignControlPointData> ForeignControlPointData;
	public TMap<TLazyObjectPtr<ULandscapeSplineSegment>,FForeignSplineSegmentData> ForeignSplineSegmentDataMap_DEPRECATED;
	public TArray<FForeignSplineSegmentData> ForeignSplineSegmentData;
}
