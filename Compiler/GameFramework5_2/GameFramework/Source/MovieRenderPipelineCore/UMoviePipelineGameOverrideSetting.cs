#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineGameOverrideSetting.h")]
public partial class UMoviePipelineGameOverrideSetting : UMoviePipelineSetting {
	public static UClass StaticClass() {return default;}
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
	///<summary>Should we override the View Distance Scale? Can be used in situations where MaxDrawDistance has been set before for in-game performance.</summary>
	public bool bOverrideViewDistanceScale;
	///<summary>Controls the view distance scale. A primitive&#39;s MaxDrawDistance is scaled by this value.</summary>
	public int ViewDistanceScale;
	///<summary>Flushing grass streaming (combined with override view distance scale) prevents visible pop-in/culling of grace instances.</summary>
	public bool bFlushGrassStreaming;
	///<summary>Experimental. If true flush the streaming managers (Texture Streaming) each frame. Allows Texture Streaming to not have visible pop-in in final frames.</summary>
	public bool bFlushStreamingManagers;
	///<summary>If true then override the virtual texture feedback resolution factor. Otherwise the value from the project renderer settings will be used.</summary>
	public bool bOverrideVirtualTextureFeedbackFactor;
	///<summary>The virtual texture feedback resolution factor. A lower factor will increase virtual texture feedback resolution.</summary>
	public int VirtualTextureFeedbackFactor;
}
