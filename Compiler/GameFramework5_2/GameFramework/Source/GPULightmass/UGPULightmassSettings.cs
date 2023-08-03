#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GPULightmassSettings.h")]
public partial class UGPULightmassSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, draw a green progress bar within each tile as it renders.</summary>
	public bool bShowProgressBars;
	///<summary>Full Bake mode renders the full lightmap resolution for every object in the scene.</summary>
	public EGPULightmassMode Mode;
	///<summary>If enabled, denoise the results on the CPU after rendering. On Completion denoises the entire lightmap when it is finished.</summary>
	public EGPULightmassDenoisingOptions DenoisingOptions;
	///<summary>Denoiser</summary>
	public EGPULightmassDenoiser Denoiser;
	///<summary>Whether to compress lightmap textures.  Disabling lightmap texture compression will reduce artifacts but increase memory and disk size by 4x.</summary>
	public bool bCompressLightmaps;
	///<summary>Total number of ray paths executed per texel across all bounces.</summary>
	public int GISamples;
	///<summary>Number of samples for stationary shadows, which are calculated and stored separately from GI.</summary>
	public int StationaryLightShadowSamples;
	///<summary>Irradiance Caching should be enabled with interior scenes to achieve more physically correct GI intensities,</summary>
	public bool bUseIrradianceCaching;
	///<summary>If Irradiance Caching is enabled, First Bounce Ray Guiding will search the hemisphere over</summary>
	public bool bUseFirstBounceRayGuiding;
	///<summary>VolumetricLightmapQualityMultiplier</summary>
	public int VolumetricLightmapQualityMultiplier;
	///<summary>Size of an Volumetric Lightmap voxel at the highest density (used around geometry), in world space units.</summary>
	public int VolumetricLightmapDetailCellSize;
	///<summary>Number of samples per Irradiance Cache cell.</summary>
	public int IrradianceCacheQuality;
	///<summary>Further prevent leaks caused by irradiance cache cells being placed inside geometry, at the cost of more fireflies and slower sampling speed. Recommended to be used with higher irradiance cache quality (&gt;=256)</summary>
	public bool bUseIrradianceCacheBackfaceDetection;
	///<summary>Size of each Irradiance Cache cell. Smaller sizes will be slower but more accurate.</summary>
	public int IrradianceCacheSpacing;
	///<summary>Reject IC entries around corners to help reduce leaking and artifacts.</summary>
	public float IrradianceCacheCornerRejection;
	///<summary>If true, visualize the Irradiance Cache cells. This can be useful for setting the IC size and quality.</summary>
	public bool bVisualizeIrradianceCache;
	///<summary>Number of samples used for First Bounce Ray Guiding, which are thrown away before sampling for lighting.</summary>
	public int FirstBounceRayGuidingTrialSamples;
	///<summary>Baking speed multiplier when Realtime is enabled in the viewer.</summary>
	public int TilePassesInSlowMode;
	///<summary>Baking speed multiplier when Realtime is disabled in the viewer.</summary>
	public int TilePassesInFullSpeedMode;
	///<summary>GPU Lightmass manages a pool for calculations of visible tiles. The pool size should be set based on the size of the</summary>
	public int LightmapTilePoolSize;
}
