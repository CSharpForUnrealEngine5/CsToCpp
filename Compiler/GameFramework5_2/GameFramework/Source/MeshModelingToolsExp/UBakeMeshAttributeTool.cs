#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeTool.h")]
///<summary>Base Mesh Bake tool</summary>
public partial class UBakeMeshAttributeTool : UMultiSelectionMeshEditingTool {
// BakeMeshAttributeTool
	public UBakeOcclusionMapToolProperties OcclusionSettings;
	public UBakeCurvatureMapToolProperties CurvatureSettings;
	public UBakeTexture2DProperties TextureSettings;
	public UBakeMultiTexture2DProperties MultiTextureSettings;
	public UMaterialInstanceDynamic WorkingPreviewMaterial;
	public UMaterialInstanceDynamic ErrorPreviewMaterial;
}
