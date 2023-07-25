#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterRootActor.h")]
///<summary>VR root. This contains nDisplay VR hierarchy in the game.</summary>
public partial class ADisplayClusterRootActor : AActor {
// DisplayClusterRootActor
	public bool GetFlushPositionAndNormal(FVector WorldPosition,FVector OutPosition,FVector OutNormal) { return default; }
	public bool MakeStageActorFlushToWall(object /*StageActor*/ StageActor,double DesiredOffsetFromFlush/*=0.0f*/) { return default; }
	public UObject GetStageGeometryComponent() { return default; }
	public UObject GetDefaultCamera() { return default; }
	public UObject GetCommonViewPoint() { return default; }
	public bool SetReplaceTextureFlagForAllViewports(bool bReplace) { return default; }
	public bool SetFreezeOuterViewports(bool bEnable) { return default; }
	public void UpdateProceduralMeshComponentData(UObject InProceduralMeshComponent/*=nullptr*/) {}
	public FDisplayClusterEditorPropertyReference ViewportScreenPercentageMultiplierRef;
	public FDisplayClusterEditorPropertyReference ViewportScreenPercentageRef;
	public FDisplayClusterEditorPropertyReference ViewportOverscanRef;
	public FDisplayClusterEditorPropertyReference FreezeRenderOuterViewportsRef;
	public FDisplayClusterEditorPropertyReference ClusterHideListRef;
	public FDisplayClusterEditorPropertyReference OuterHideListRef;
	public FDisplayClusterEditorPropertyReference EnableInnerFrustumsRef;
	public FDisplayClusterEditorPropertyReference EnableColorGradingRef;
	public FDisplayClusterEditorPropertyReference ClusterColorGradingRef;
	public FDisplayClusterEditorPropertyReference PerViewportColorGradingRef;
	public FDisplayClusterEditorPropertyReference EnableViewportOCIORef;
	public FDisplayClusterEditorPropertyReference AllViewportColorConfigurationRef;
	public FDisplayClusterEditorPropertyReference PerViewportOCIOProfilesRef;
	public FDisplayClusterEditorPropertyReference EnableLightcardsRef;
	public FDisplayClusterEditorPropertyReference LightCardBlendingModeRef;
	public FDisplayClusterEditorPropertyReference LightCardContentRef;
	public FDisplayClusterEditorPropertyReference LightcardOCIOModeRef;
	public FDisplayClusterEditorPropertyReference LightcardAllViewportColorConfigurationRef;
	public FDisplayClusterEditorPropertyReference LightcardPerViewportOCIOProfilesRef;
	public FDisplayClusterEditorPropertyReference MediaSettingsRef;
	public string ConfigDataName;
	public USceneComponent DisplayClusterRootComponent;
	public UDisplayClusterCameraComponent DefaultViewPoint;
	public UDisplayClusterSyncTickComponent SyncTickComponent;
	public UDisplayClusterStageGeometryComponent StageGeometryComponent;
	public TArray<FDisplayClusterComponentRef> InnerFrustumPriority;
	public UDisplayClusterConfigurationData CurrentConfigData;
	public bool bMoviePipelineRenderPass;
	public bool bPreviewEnable;
	public float PreviewRenderTargetRatioMult;
	public bool bPreviewEnablePostProcess;
	public bool bFreezePreviewRender;
	public bool bPreviewICVFXFrustums;
	public float PreviewICVFXFrustumsFarDistance;
	public string PreviewNodeId;
	public EDisplayClusterConfigurationRenderMode RenderMode;
	public int TickPerFrame;
	public int ViewportsPerFrame;
	public int PreviewMaxTextureDimension;
	public TMap<string,UDisplayClusterPreviewComponent> PreviewComponents;
	public bool bDeferPreviewGeneration;
}
