#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GPULightmassSettings.h")]
public partial class UGPULightmassSettings : UObject {
// GPULightmassSettings
	public bool bShowProgressBars;
	public EGPULightmassMode Mode;
	public EGPULightmassDenoisingOptions DenoisingOptions;
	public EGPULightmassDenoiser Denoiser;
	public bool bCompressLightmaps;
	public int GISamples;
	public int StationaryLightShadowSamples;
	public bool bUseIrradianceCaching;
	public bool bUseFirstBounceRayGuiding;
	public int VolumetricLightmapQualityMultiplier;
	public int VolumetricLightmapDetailCellSize;
	public int IrradianceCacheQuality;
	public bool bUseIrradianceCacheBackfaceDetection;
	public int IrradianceCacheSpacing;
	public float IrradianceCacheCornerRejection;
	public bool bVisualizeIrradianceCache;
	public int FirstBounceRayGuidingTrialSamples;
	public int TilePassesInSlowMode;
	public int TilePassesInFullSpeedMode;
	public int LightmapTilePoolSize;
}
