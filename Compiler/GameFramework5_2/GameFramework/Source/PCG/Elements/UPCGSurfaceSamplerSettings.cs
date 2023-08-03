#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	///<summary>If no Bounding Shape input is provided the actor bounds are used to limit the sample generation area.</summary>
	public bool bUnbounded;
	///<summary>bApplyDensityToPoints</summary>
	public bool bApplyDensityToPoints;
	///<summary>PointSteepness</summary>
	public float PointSteepness;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
	///<summary>PointRadius_DEPRECATED</summary>
	public float PointRadius_DEPRECATED;
}
