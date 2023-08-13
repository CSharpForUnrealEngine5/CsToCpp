namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomToMeshTool.h")]
public partial class UGroomToMeshTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UGroomToMeshToolProperties Settings;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>TargetGroom</summary>
	public TLazyObjectPtr<AGroomActor> TargetGroom;
	///<summary>PreviewGeom</summary>
	public UPreviewGeometry PreviewGeom;
	///<summary>MeshMaterial</summary>
	public UMaterialInterface MeshMaterial;
	///<summary>UVMaterial</summary>
	public UMaterialInterface UVMaterial;
}
