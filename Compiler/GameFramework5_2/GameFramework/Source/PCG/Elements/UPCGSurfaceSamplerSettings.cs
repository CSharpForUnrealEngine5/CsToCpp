#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSurfaceSampler.h")]
public partial class UPCGSurfaceSamplerSettings : UPCGSettings {
// PCGSurfaceSamplerSettings
	public float PointsPerSquaredMeter;
	public FVector PointExtents;
	public float Looseness;
	public bool bUnbounded;
	public bool bApplyDensityToPoints;
	public float PointSteepness;
	public bool bKeepZeroDensityPoints;
	public float PointRadius_DEPRECATED;
}
