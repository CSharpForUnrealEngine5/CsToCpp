namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple tool to combine multiple meshes into a single mesh asset</summary>
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
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
	///<summary>CollisionPreview</summary>
	public UPreviewGeometry CollisionPreview;
	///<summary>GenerateProcess</summary>
	public UGenerateStaticMeshLODProcess GenerateProcess;
}
