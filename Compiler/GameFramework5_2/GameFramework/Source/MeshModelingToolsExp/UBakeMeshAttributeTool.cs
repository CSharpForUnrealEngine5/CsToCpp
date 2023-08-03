#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Mesh Bake tool</summary>
[CppInclude("BakeMeshAttributeTool.h")]
public partial class UBakeMeshAttributeTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Bake tool property sets</summary>
	public UBakeOcclusionMapToolProperties OcclusionSettings;
	///<summary>CurvatureSettings</summary>
	public UBakeCurvatureMapToolProperties CurvatureSettings;
	///<summary>TextureSettings</summary>
	public UBakeTexture2DProperties TextureSettings;
	///<summary>MultiTextureSettings</summary>
	public UBakeMultiTexture2DProperties MultiTextureSettings;
	///<summary>Preview materials</summary>
	public UMaterialInstanceDynamic WorkingPreviewMaterial;
	///<summary>ErrorPreviewMaterial</summary>
	public UMaterialInstanceDynamic ErrorPreviewMaterial;
}
