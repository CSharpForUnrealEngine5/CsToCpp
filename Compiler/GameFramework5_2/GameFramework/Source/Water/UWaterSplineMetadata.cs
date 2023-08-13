namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterSplineMetadata.h")]
public partial class UWaterSplineMetadata : USplineMetadata {
	public static UClass StaticClass() {return default;}
	///<summary>Depth</summary>
	public FInterpCurveFloat Depth;
	///<summary>The Current of the water at this vertex.  Magnitude and direction</summary>
	public FInterpCurveFloat WaterVelocityScalar;
	///<summary>Rivers Only: The width of the river (from center) in each direction</summary>
	public FInterpCurveFloat RiverWidth;
	///<summary>A scalar used to define intensity of the water audio along the spline</summary>
	public FInterpCurveFloat AudioIntensity;
	///<summary>Whether water velocity visualization should be displayed</summary>
	public bool bShouldVisualizeWaterVelocity;
	///<summary>Whether river width visualization should be displayed</summary>
	public bool bShouldVisualizeRiverWidth;
	///<summary>Whether depth visualization should be displayed</summary>
	public bool bShouldVisualizeDepth;
	///<summary>WaterVelocity_DEPRECATED</summary>
	public FInterpCurveVector WaterVelocity_DEPRECATED;
}
