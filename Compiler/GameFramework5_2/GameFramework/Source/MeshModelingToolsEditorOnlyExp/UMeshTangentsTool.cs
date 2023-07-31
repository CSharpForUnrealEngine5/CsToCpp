#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Simplifying Tool</summary>
[CppInclude("MeshTangentsTool.h")]
public partial class UMeshTangentsTool : USingleSelectionMeshEditingTool {
	///<summary>Settings</summary>
	public UMeshTangentsToolProperties Settings;
	///<summary>DefaultMaterial</summary>
	public UMaterialInterface DefaultMaterial;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>PreviewGeometry</summary>
	public UPreviewGeometry PreviewGeometry;
}
