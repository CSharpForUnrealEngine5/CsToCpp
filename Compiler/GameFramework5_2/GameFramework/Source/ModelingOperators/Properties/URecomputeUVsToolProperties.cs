#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/RecomputeUVsProperties.h")]
public partial class URecomputeUVsToolProperties : UInteractiveToolPropertySet {
// RecomputeUVsToolProperties
	public bool bEnablePolygroupSupport;
	public ERecomputeUVsPropertiesIslandMode IslandGeneration;
	public ERecomputeUVsPropertiesUnwrapType UnwrapType;
	public ERecomputeUVsToolOrientationMode AutoRotation;
	public bool bPreserveIrregularity;
	public int SmoothingSteps;
	public float SmoothingAlpha;
	public float MergingDistortionThreshold;
	public float MergingAngleThreshold;
	public ERecomputeUVsPropertiesLayoutType LayoutType;
	public int TextureResolution;
	public float NormalizeScale;
	public bool bEnableUDIMLayout;
	public bool bUDIMCVAREnabled;
}
