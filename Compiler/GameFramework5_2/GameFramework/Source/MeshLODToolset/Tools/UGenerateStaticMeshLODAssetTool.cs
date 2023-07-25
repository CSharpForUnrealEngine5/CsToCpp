#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
///<summary>Simple tool to combine multiple meshes into a single mesh asset</summary>
public partial class UGenerateStaticMeshLODAssetTool : UMultiSelectionMeshEditingTool {
// GenerateStaticMeshLODAssetTool
	public UGenerateStaticMeshLODAssetToolOutputProperties OutputProperties;
	public UGenerateStaticMeshLODAssetToolProperties BasicProperties;
	public UGenerateStaticMeshLODAssetToolPresetProperties PresetProperties;
	public UGenerateStaticMeshLODAssetToolTextureProperties TextureProperties;
	public UCollisionGeometryVisualizationProperties CollisionVizSettings;
	public UMeshOpPreviewWithBackgroundCompute PreviewWithBackgroundCompute;
	public TArray<UTexture2D> PreviewTextures;
	public TArray<UMaterialInterface> PreviewMaterials;
	public UPhysicsObjectToolPropertySet ObjectData;
	public UMaterialInterface LineMaterial;
	public UPreviewGeometry CollisionPreview;
	public UGenerateStaticMeshLODProcess GenerateProcess;
}
