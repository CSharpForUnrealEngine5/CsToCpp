#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSplineSampler.h")]
public partial struct FPCGSplineSamplerParams {
	public EPCGSplineSamplingMode Mode;
	public EPCGSplineSamplingDimension Dimension;
	public EPCGSplineSamplingFill Fill;
	public int SubdivisionsPerSegment;
	public float DistanceIncrement;
	public int NumPlanarSubdivisions;
	public int NumHeightSubdivisions;
	public bool bComputeDirectionDelta;
	public string NextDirectionDeltaAttribute;
	public bool bComputeCurvature;
	public string CurvatureAttribute;
	public float InteriorSampleSpacing;
	public float InteriorBorderSampleSpacing;
	public bool bTreatSplineAsPolyline;
	public EPCGSplineSamplingInteriorOrientation InteriorOrientation;
	public bool bProjectOntoSurface;
	public FRuntimeFloatCurve InteriorDensityFalloffCurve;
	public bool bSeedFromLocalPosition;
	public bool bSeedFrom2DPosition;
}
