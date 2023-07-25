#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
///<summary>Tool</summary>
public partial class UBakeRenderCaptureTool : UMultiSelectionMeshEditingTool {
// BakeRenderCaptureTool
	public TArray<AActor> Actors;
	public UBakeRenderCaptureToolProperties Settings;
	public URenderCaptureProperties RenderCaptureProperties;
	public UBakeRenderCaptureInputToolProperties InputMeshSettings;
	public UBakeRenderCaptureVisualizationProperties VisualizationProps;
	public UBakeRenderCaptureResults ResultSettings;
	public UTexture2D EmptyNormalMap;
	public UTexture2D EmptyColorMapBlack;
	public UTexture2D EmptyColorMapWhite;
	public UTexture2D EmptyEmissiveMap;
	public UTexture2D EmptyOpacityMap;
	public UTexture2D EmptySubsurfaceColorMap;
	public UTexture2D EmptyPackedMRSMap;
	public UTexture2D EmptyRoughnessMap;
	public UTexture2D EmptyMetallicMap;
	public UTexture2D EmptySpecularMap;
	public UMaterialInstanceDynamic WorkingPreviewMaterial;
	public UMaterialInstanceDynamic ErrorPreviewMaterial;
	public UMaterialInstanceDynamic PreviewMaterialRC;
	public UMaterialInstanceDynamic PreviewMaterialPackedRC;
	public UMaterialInstanceDynamic PreviewMaterialRC_Subsurface;
	public UMaterialInstanceDynamic PreviewMaterialPackedRC_Subsurface;
	public UPreviewMesh PreviewMesh;
}
