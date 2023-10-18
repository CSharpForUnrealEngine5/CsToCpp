namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSurfaceSampler.h")]
public partial class UPCGSurfaceSamplerSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>PointsPerSquaredMeter</summary>
	public float PointsPerSquaredMeter;
	///<summary>PointExtents</summary>
	public FVector PointExtents;
	///<summary>Looseness</summary>
	public float Looseness;
	///<summary>If no Bounding Shape input is provided, the actor bounds are used to limit the sample generation domain.</summary>
	public bool bUnbounded;
	///<summary>bApplyDensityToPoints</summary>
	public bool bApplyDensityToPoints;
	///<summary>Each PCG point represents a discretized, volumetric region of world space. The points&#39; Steepness value [0.0 to</summary>
	public float PointSteepness;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
	///<summary>PointRadius_DEPRECATED</summary>
	public float PointRadius_DEPRECATED;
}
