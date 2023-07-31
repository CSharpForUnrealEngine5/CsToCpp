#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Vertex Baking Tool</summary>
[CppInclude("BakeMeshAttributeVertexTool.h")]
public partial class UBakeMeshAttributeVertexTool : UBakeMeshAttributeTool {
	///<summary>InputMeshSettings</summary>
	public UBakeInputMeshProperties InputMeshSettings;
	///<summary>Settings</summary>
	public UBakeMeshAttributeVertexToolProperties Settings;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>PreviewMaterial</summary>
	public UMaterialInstanceDynamic PreviewMaterial;
	///<summary>PreviewAlphaMaterial</summary>
	public UMaterialInstanceDynamic PreviewAlphaMaterial;
}
