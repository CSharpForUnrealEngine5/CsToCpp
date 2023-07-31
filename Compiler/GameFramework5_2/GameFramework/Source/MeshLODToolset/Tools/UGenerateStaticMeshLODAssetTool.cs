#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple tool to combine multiple meshes into a single mesh asset</summary>
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetTool : UMultiSelectionMeshEditingTool {
	///<summary>OutputProperties</summary>
	public UGenerateStaticMeshLODAssetToolOutputProperties OutputProperties;
	///<summary>BasicProperties</summary>
	public UGenerateStaticMeshLODAssetToolProperties BasicProperties;
	///<summary>PresetProperties</summary>
	public UGenerateStaticMeshLODAssetToolPresetProperties PresetProperties;
	///<summary>TextureProperties</summary>
	public UGenerateStaticMeshLODAssetToolTextureProperties TextureProperties;
	///<summary>CollisionVizSettings</summary>
	public UCollisionGeometryVisualizationProperties CollisionVizSettings;
	///<summary>PreviewWithBackgroundCompute</summary>
	public UMeshOpPreviewWithBackgroundCompute PreviewWithBackgroundCompute;
	///<summary>PreviewTextures</summary>
	public TArray<UTexture2D> PreviewTextures;
	///<summary>PreviewMaterials</summary>
	public TArray<UMaterialInterface> PreviewMaterials;
	///<summary>ObjectData</summary>
	public UPhysicsObjectToolPropertySet ObjectData;
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>CollisionPreview</summary>
	public UPreviewGeometry CollisionPreview;
	///<summary>GenerateProcess</summary>
	public UGenerateStaticMeshLODProcess GenerateProcess;
}
