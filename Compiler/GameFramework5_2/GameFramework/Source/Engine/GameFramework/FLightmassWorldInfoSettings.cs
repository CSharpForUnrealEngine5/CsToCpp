#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/WorldSettings.h")]
public partial struct FLightmassWorldInfoSettings {
	public float StaticLightingLevelScale;
	public int NumIndirectLightingBounces;
	public int NumSkyLightingBounces;
	public float IndirectLightingQuality;
	public float IndirectLightingSmoothness;
	public FColor EnvironmentColor;
	public float EnvironmentIntensity;
	public float EmissiveBoost;
	public float DiffuseBoost;
	public EVolumeLightingMethod VolumeLightingMethod;
	public bool bUseAmbientOcclusion;
	public bool bGenerateAmbientOcclusionMaterialMask;
	public bool bVisualizeMaterialDiffuse;
	public bool bVisualizeAmbientOcclusion;
	public bool bCompressLightmaps;
	public float VolumetricLightmapDetailCellSize;
	public float VolumetricLightmapMaximumBrickMemoryMb;
	public float VolumetricLightmapSphericalHarmonicSmoothing;
	public float VolumeLightSamplePlacementScale;
	public float DirectIlluminationOcclusionFraction;
	public float IndirectIlluminationOcclusionFraction;
	public float OcclusionExponent;
	public float FullyOccludedSamplesFraction;
	public float MaxOcclusionDistance;
}
