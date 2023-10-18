namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which configures the global game overrides.</summary>
[CppInclude("Graph/Nodes/MovieGraphGlobalGameOverrides.h")]
public partial class UMovieGraphGlobalGameOverridesNode : UMovieGraphSettingNode {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride_GameModeOverride</summary>
	public bool bOverride_GameModeOverride;
	///<summary>bOverride_CinematicQualitySettings</summary>
	public bool bOverride_CinematicQualitySettings;
	///<summary>bOverride_TextureStreaming</summary>
	public bool bOverride_TextureStreaming;
	///<summary>bOverride_UseLODZero</summary>
	public bool bOverride_UseLODZero;
	///<summary>bOverride_DisableHLODs</summary>
	public bool bOverride_DisableHLODs;
	///<summary>bOverride_UseHighQualityShadows</summary>
	public bool bOverride_UseHighQualityShadows;
	///<summary>bOverride_ShadowDistanceScale</summary>
	public bool bOverride_ShadowDistanceScale;
	///<summary>bOverride_ShadowRadiusThreshold</summary>
	public bool bOverride_ShadowRadiusThreshold;
	///<summary>bOverride_OverrideViewDistanceScale</summary>
	public bool bOverride_OverrideViewDistanceScale;
	///<summary>bOverride_ViewDistanceScale</summary>
	public bool bOverride_ViewDistanceScale;
	///<summary>bOverride_FlushGrassStreaming</summary>
	public bool bOverride_FlushGrassStreaming;
	///<summary>bOverride_FlushStreamingManagers</summary>
	public bool bOverride_FlushStreamingManagers;
	///<summary>bOverride_VirtualTextureFeedbackFactor</summary>
	public bool bOverride_VirtualTextureFeedbackFactor;
	///<summary>bOverride_DisableGPUTimeout</summary>
	public bool bOverride_DisableGPUTimeout;
	///<summary>Optional Game Mode to override the map&#39;s default game mode with. This can be useful if the game&#39;s normal mode displays UI elements or loading screens that you don&#39;t want captured.</summary>
	public UClass GameModeOverride;
	///<summary>If true, automatically set the engine to the Cinematic Scalability quality settings during render. See the Scalability Reference documentation for information on how to edit cvars to add/change default quality values.</summary>
	public bool bCinematicQualitySettings;
	///<summary>Defines which If true, when using texture streaming fully load the required textures each frame instead of loading them in over time. This solves objects being blurry after camera cuts.</summary>
	public EMoviePipelineTextureStreamingMethod TextureStreaming;
	///<summary>Should we try to use the highest quality LOD for meshes and particle systems regardless of distance?</summary>
	public bool bUseLODZero;
	///<summary>Should we disable Hierarchical LODs and instead use their real meshes regardless of distance?</summary>
	public bool bDisableHLODs;
	///<summary>Should we override shadow-related CVars with some high quality preset settings?</summary>
	public bool bUseHighQualityShadows;
	///<summary>Scalability option to trade shadow distance versus performance for directional lights</summary>
	public int ShadowDistanceScale;
	///<summary>Cull shadow casters if they are too small, value is the minimal screen space bounding sphere radius</summary>
	public float ShadowRadiusThreshold;
	///<summary>Controls the view distance scale. A primitive&#39;s MaxDrawDistance is scaled by this value.</summary>
	public int ViewDistanceScale;
	///<summary>Flushing grass streaming (combined with override view distance scale) prevents visible pop-in/culling of grace instances.</summary>
	public bool bFlushGrassStreaming;
	///<summary>Experimental. If true flush the streaming managers (Texture Streaming) each frame. Allows Texture Streaming to not have visible pop-in in final frames.</summary>
	public bool bFlushStreamingManagers;
	///<summary>The virtual texture feedback resolution factor. A lower factor will increase virtual texture feedback resolution.</summary>
	public int VirtualTextureFeedbackFactor;
}
