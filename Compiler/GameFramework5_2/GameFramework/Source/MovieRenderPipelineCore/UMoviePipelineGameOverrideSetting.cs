#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineGameOverrideSetting.h")]
public partial class UMoviePipelineGameOverrideSetting : UMoviePipelineSetting {
// MoviePipelineGameOverrideSetting
	public UClass GameModeOverride;
	public bool bCinematicQualitySettings;
	public EMoviePipelineTextureStreamingMethod TextureStreaming;
	public bool bUseLODZero;
	public bool bDisableHLODs;
	public bool bUseHighQualityShadows;
	public int ShadowDistanceScale;
	public float ShadowRadiusThreshold;
	public bool bOverrideViewDistanceScale;
	public int ViewDistanceScale;
	public bool bFlushGrassStreaming;
	public bool bFlushStreamingManagers;
	public bool bOverrideVirtualTextureFeedbackFactor;
	public int VirtualTextureFeedbackFactor;
}
