namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSplineSampler.h")]
public partial struct FPCGSplineSamplerParams {
	public EPCGSplineSamplingDimension Dimension;
	public EPCGSplineSamplingMode Mode;
	public EPCGSplineSamplingFill Fill;
	public int SubdivisionsPerSegment;
	public float DistanceIncrement;
	public int NumPlanarSubdivisions;
	public int NumHeightSubdivisions;
	public bool bComputeDirectionDelta;
	public FName NextDirectionDeltaAttribute;
	public bool bComputeCurvature;
	public FName CurvatureAttribute;
	public bool bUnbounded;
	public float InteriorSampleSpacing;
	public float InteriorBorderSampleSpacing;
	public bool bTreatSplineAsPolyline;
	public EPCGSplineSamplingInteriorOrientation InteriorOrientation;
	public bool bProjectOntoSurface;
	public FRuntimeFloatCurve InteriorDensityFalloffCurve;
	public float PointSteepness;
	public bool bSeedFromLocalPosition;
	public bool bSeedFrom2DPosition;
}
