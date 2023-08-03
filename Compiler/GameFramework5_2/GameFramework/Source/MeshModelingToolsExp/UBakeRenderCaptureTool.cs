#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool</summary>
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Actors</summary>
	public TArray<AActor> Actors;
	///<summary>Settings</summary>
	public UBakeRenderCaptureToolProperties Settings;
	///<summary>RenderCaptureProperties</summary>
	public URenderCaptureProperties RenderCaptureProperties;
	///<summary>InputMeshSettings</summary>
	public UBakeRenderCaptureInputToolProperties InputMeshSettings;
	///<summary>VisualizationProps</summary>
	public UBakeRenderCaptureVisualizationProperties VisualizationProps;
	///<summary>The computed textures are displayed in the details panel and used in the preview material, they are written</summary>
	public UBakeRenderCaptureResults ResultSettings;
	///<summary>Empty maps are shown when nothing is computed</summary>
	public UTexture2D EmptyNormalMap;
	///<summary>EmptyColorMapBlack</summary>
	public UTexture2D EmptyColorMapBlack;
	///<summary>EmptyColorMapWhite</summary>
	public UTexture2D EmptyColorMapWhite;
	///<summary>EmptyEmissiveMap</summary>
	public UTexture2D EmptyEmissiveMap;
	///<summary>EmptyOpacityMap</summary>
	public UTexture2D EmptyOpacityMap;
	///<summary>EmptySubsurfaceColorMap</summary>
	public UTexture2D EmptySubsurfaceColorMap;
	///<summary>EmptyPackedMRSMap</summary>
	public UTexture2D EmptyPackedMRSMap;
	///<summary>EmptyRoughnessMap</summary>
	public UTexture2D EmptyRoughnessMap;
	///<summary>EmptyMetallicMap</summary>
	public UTexture2D EmptyMetallicMap;
	///<summary>EmptySpecularMap</summary>
	public UTexture2D EmptySpecularMap;
	///<summary>WorkingPreviewMaterial</summary>
	public UMaterialInstanceDynamic WorkingPreviewMaterial;
	///<summary>ErrorPreviewMaterial</summary>
	public UMaterialInstanceDynamic ErrorPreviewMaterial;
	///<summary>PreviewMaterialRC</summary>
	public UMaterialInstanceDynamic PreviewMaterialRC;
	///<summary>PreviewMaterialPackedRC</summary>
	public UMaterialInstanceDynamic PreviewMaterialPackedRC;
	///<summary>PreviewMaterialRC_Subsurface</summary>
	public UMaterialInstanceDynamic PreviewMaterialRC_Subsurface;
	///<summary>PreviewMaterialPackedRC_Subsurface</summary>
	public UMaterialInstanceDynamic PreviewMaterialPackedRC_Subsurface;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
}
