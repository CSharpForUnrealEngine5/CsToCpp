#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
public partial struct FMeshApproximationSettings {
	public EMeshApproximationType OutputType;
	public float ApproximationAccuracy;
	public int ClampVoxelDimension;
	public bool bAttemptAutoThickening;
	public float TargetMinThicknessMultiplier;
	public bool bIgnoreTinyParts;
	public float TinyPartSizeMultiplier;
	public EMeshApproximationBaseCappingType BaseCapping;
	public float WindingThreshold;
	public bool bFillGaps;
	public float GapDistance;
	public EOccludedGeometryFilteringPolicy OcclusionMethod;
	public bool bOccludeFromBottom;
	public EMeshApproximationSimplificationPolicy SimplifyMethod;
	public int TargetTriCount;
	public float TrianglesPerM;
	public float GeometricDeviation;
	public EMeshApproximationGroundPlaneClippingPolicy GroundClipping;
	public float GroundClippingZHeight;
	public bool bEstimateHardNormals;
	public float HardNormalAngle;
	public EMeshApproximationUVGenerationPolicy UVGenerationMethod;
	public int InitialPatchCount;
	public float CurvatureAlignment;
	public float MergingThreshold;
	public float MaxAngleDeviation;
	public bool bGenerateNaniteEnabledMesh;
	public float NaniteProxyTrianglePercent;
	public bool bSupportRayTracing;
	public bool bAllowDistanceField;
	public int MultiSamplingAA;
	public int RenderCaptureResolution;
	public FMaterialProxySettings MaterialSettings;
	public float CaptureFieldOfView;
	public float NearPlaneDist;
	public bool bUseRenderLODMeshes;
	public bool bEnableSimplifyPrePass;
	public bool bEnableParallelBaking;
	public bool bPrintDebugMessages;
	public bool bEmitFullDebugMesh;
}
