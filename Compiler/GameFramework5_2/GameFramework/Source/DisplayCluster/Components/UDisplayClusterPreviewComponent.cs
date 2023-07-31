#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay Viewport preview component (Editor)</summary>
[CppInclude("Components/DisplayClusterPreviewComponent.h")]
public partial class UDisplayClusterPreviewComponent : UActorComponent {
	///<summary>Texture for preview material</summary>
	public UTextureRenderTarget2D RenderTarget;
	///<summary>Texture when DCRA has post process disabled but is requesting a post process render target.</summary>
	public UTextureRenderTarget2D RenderTargetPostProcess;
	///<summary>Saved mesh policy params</summary>
	public FDisplayClusterConfigurationProjection WarpMeshSavedProjectionPolicy;
	///<summary>RootActor</summary>
	public ADisplayClusterRootActor RootActor;
	///<summary>ViewportId</summary>
	public string ViewportId;
	///<summary>ClusterNodeId</summary>
	public string ClusterNodeId;
	///<summary>ViewportConfig</summary>
	public UDisplayClusterConfigurationViewport ViewportConfig;
	///<summary>PreviewMesh</summary>
	public UMeshComponent PreviewMesh;
	///<summary>bIsRootActorPreviewMesh</summary>
	public bool bIsRootActorPreviewMesh;
	///<summary>OriginalMaterial</summary>
	public UMaterial OriginalMaterial;
	///<summary>PreviewMaterial</summary>
	public UMaterial PreviewMaterial;
	///<summary>PreviewMaterialInstance</summary>
	public UMaterialInstanceDynamic PreviewMaterialInstance;
	///<summary>OverrideTexture</summary>
	public UTexture OverrideTexture;
}
