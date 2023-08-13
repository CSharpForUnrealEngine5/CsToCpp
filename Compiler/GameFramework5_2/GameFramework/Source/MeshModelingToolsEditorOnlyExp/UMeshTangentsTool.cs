namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Simplifying Tool</summary>
[CppInclude("MeshTangentsTool.h")]
public partial class UMeshTangentsTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UMeshTangentsToolProperties Settings;
	///<summary>DefaultMaterial</summary>
	public UMaterialInterface DefaultMaterial;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>PreviewGeometry</summary>
	public UPreviewGeometry PreviewGeometry;
}
