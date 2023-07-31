#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>VR root. This contains nDisplay VR hierarchy in the game.</summary>
[CppInclude("DisplayClusterRootActor.h")]
public partial class ADisplayClusterRootActor : AActor {
	///<summary>GetFlushPositionAndNormal</summary>
	public  bool GetFlushPositionAndNormal(FVector WorldPosition,FVector OutPosition,FVector OutNormal) { return default; }
	///<summary>MakeStageActorFlushToWall</summary>
	public  bool MakeStageActorFlushToWall(object /*StageActor*/ StageActor,double DesiredOffsetFromFlush/*=0.0f*/) { return default; }
	///<summary>GetStageGeometryComponent</summary>
	public  UDisplayClusterStageGeometryComponent GetStageGeometryComponent() { return default; }
	///<summary>GetDefaultCamera</summary>
	public  UDisplayClusterCameraComponent GetDefaultCamera() { return default; }
	///<summary>Get the view origin most commonly used by viewports in this cluster.</summary>
	public  USceneComponent GetCommonViewPoint() { return default; }
	///<summary>SetReplaceTextureFlagForAllViewports</summary>
	public  bool SetReplaceTextureFlagForAllViewports(bool bReplace) { return default; }
	///<summary>SetFreezeOuterViewports</summary>
	public  bool SetFreezeOuterViewports(bool bEnable) { return default; }
	///<summary>Update the geometry of the procedural mesh component(s) referenced inside nDisplay</summary>
	public  void UpdateProceduralMeshComponentData(UProceduralMeshComponent InProceduralMeshComponent/*=nullptr*/) {}
	///<summary>ViewportScreenPercentageMultiplierRef</summary>
	public FDisplayClusterEditorPropertyReference ViewportScreenPercentageMultiplierRef;
	///<summary>Adjust resolution scaling for an individual viewport.  Viewport Screen Percentage Multiplier is applied to this value.</summary>
	public FDisplayClusterEditorPropertyReference ViewportScreenPercentageRef;
	///<summary>Render a larger frame than specified in the configuration to achieve continuity across displays when using post-processing effects.</summary>
	public FDisplayClusterEditorPropertyReference ViewportOverscanRef;
	///<summary>FreezeRenderOuterViewportsRef</summary>
	public FDisplayClusterEditorPropertyReference FreezeRenderOuterViewportsRef;
	///<summary>ClusterHideListRef</summary>
	public FDisplayClusterEditorPropertyReference ClusterHideListRef;
	///<summary>OuterHideListRef</summary>
	public FDisplayClusterEditorPropertyReference OuterHideListRef;
	///<summary>EnableInnerFrustumsRef</summary>
	public FDisplayClusterEditorPropertyReference EnableInnerFrustumsRef;
	///<summary>EnableColorGradingRef</summary>
	public FDisplayClusterEditorPropertyReference EnableColorGradingRef;
	///<summary>ClusterColorGradingRef</summary>
	public FDisplayClusterEditorPropertyReference ClusterColorGradingRef;
	///<summary>PerViewportColorGradingRef</summary>
	public FDisplayClusterEditorPropertyReference PerViewportColorGradingRef;
	///<summary>EnableViewportOCIORef</summary>
	public FDisplayClusterEditorPropertyReference EnableViewportOCIORef;
	///<summary>AllViewportColorConfigurationRef</summary>
	public FDisplayClusterEditorPropertyReference AllViewportColorConfigurationRef;
	///<summary>PerViewportOCIOProfilesRef</summary>
	public FDisplayClusterEditorPropertyReference PerViewportOCIOProfilesRef;
	///<summary>EnableLightcardsRef</summary>
	public FDisplayClusterEditorPropertyReference EnableLightcardsRef;
	///<summary>LightCardBlendingModeRef</summary>
	public FDisplayClusterEditorPropertyReference LightCardBlendingModeRef;
	///<summary>LightCardContentRef</summary>
	public FDisplayClusterEditorPropertyReference LightCardContentRef;
	///<summary>LightcardOCIOModeRef</summary>
	public FDisplayClusterEditorPropertyReference LightcardOCIOModeRef;
	///<summary>LightcardAllViewportColorConfigurationRef</summary>
	public FDisplayClusterEditorPropertyReference LightcardAllViewportColorConfigurationRef;
	///<summary>LightcardPerViewportOCIOProfilesRef</summary>
	public FDisplayClusterEditorPropertyReference LightcardPerViewportOCIOProfilesRef;
	///<summary>Media</summary>
	public FDisplayClusterEditorPropertyReference MediaSettingsRef;
	///<summary>Name of the CurrentConfigData asset. Only required if this is a parent of a DisplayClusterBlueprint.</summary>
	public string ConfigDataName;
	///<summary>The root component for our hierarchy.</summary>
	public USceneComponent DisplayClusterRootComponent;
	///<summary>Default camera component. It&#39;s an outer camera in VP/ICVFX terminology. Always exists on a DCRA instance.</summary>
	public UDisplayClusterCameraComponent DefaultViewPoint;
	///<summary>Helper sync component. Performs sync procedure during Tick phase.</summary>
	public UDisplayClusterSyncTickComponent SyncTickComponent;
	///<summary>Component that stores the stage&#39;s geometry map, which is used to make objects flush with the stage&#39;s walls and ceilings</summary>
	public UDisplayClusterStageGeometryComponent StageGeometryComponent;
	///<summary>Set the priority for inner frustum rendering if there is any overlap when enabling multiple ICVFX cameras.</summary>
	public TArray<FDisplayClusterComponentRef> InnerFrustumPriority;
	///<summary>If set from the DisplayCluster BP Compiler it will be loaded from the class default subobjects in run-time.</summary>
	public UDisplayClusterConfigurationData CurrentConfigData;
	///<summary>When the MRQ is rendered, this flag is raised.</summary>
	public bool bMoviePipelineRenderPass;
	///<summary>Render the scene and display it as a preview on the nDisplay root actor in the editor.  This will impact editor performance.</summary>
	public bool bPreviewEnable;
	///<summary>Adjust resolution scaling for the editor preview.</summary>
	public float PreviewRenderTargetRatioMult;
	///<summary>Enable PostProcess for preview.</summary>
	public bool bPreviewEnablePostProcess;
	///<summary>Freeze preview render.  This will impact editor performance.</summary>
	public bool bFreezePreviewRender;
	///<summary>Render ICVFX Frustums</summary>
	public bool bPreviewICVFXFrustums;
	///<summary>Render ICVFX Frustums</summary>
	public float PreviewICVFXFrustumsFarDistance;
	///<summary>Selectively preview a specific viewport or show all/none.</summary>
	public string PreviewNodeId;
	///<summary>Render Mode</summary>
	public EDisplayClusterConfigurationRenderMode RenderMode;
	///<summary>Tick Per Frame</summary>
	public int TickPerFrame;
	///<summary>Max amount of Viewports Per Frame</summary>
	public int ViewportsPerFrame;
	///<summary>The maximum dimension of any internal texture for preview. Use less memory for large preview viewports</summary>
	public int PreviewMaxTextureDimension;
	///<summary>PreviewComponents</summary>
	public TMap<string,UDisplayClusterPreviewComponent> PreviewComponents;
	///<summary>bDeferPreviewGeneration</summary>
	public bool bDeferPreviewGeneration;
}
