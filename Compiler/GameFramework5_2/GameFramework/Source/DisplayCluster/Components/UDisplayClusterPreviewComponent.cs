#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DisplayClusterPreviewComponent.h")]
///<summary>nDisplay Viewport preview component (Editor)</summary>
public partial class UDisplayClusterPreviewComponent : UActorComponent {
// DisplayClusterPreviewComponent
	public UTextureRenderTarget2D RenderTarget;
	public UTextureRenderTarget2D RenderTargetPostProcess;
	public FDisplayClusterConfigurationProjection WarpMeshSavedProjectionPolicy;
	public ADisplayClusterRootActor RootActor;
	public string ViewportId;
	public string ClusterNodeId;
	public UDisplayClusterConfigurationViewport ViewportConfig;
	public UMeshComponent PreviewMesh;
	public bool bIsRootActorPreviewMesh;
	public UMaterial OriginalMaterial;
	public UMaterial PreviewMaterial;
	public UMaterialInstanceDynamic PreviewMaterialInstance;
	public UTexture OverrideTexture;
}
