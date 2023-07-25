#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterSplineMetadata.h")]
public partial class UWaterSplineMetadata : USplineMetadata {
// WaterSplineMetadata
	public FInterpCurveFloat Depth;
	public FInterpCurveFloat WaterVelocityScalar;
	public FInterpCurveFloat RiverWidth;
	public FInterpCurveFloat AudioIntensity;
	public bool bShouldVisualizeWaterVelocity;
	public bool bShouldVisualizeRiverWidth;
	public bool bShouldVisualizeDepth;
	public FInterpCurveVector WaterVelocity_DEPRECATED;
}
