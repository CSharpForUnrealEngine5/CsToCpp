namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Plane Cutting Tool</summary>
[CppInclude("CSGMeshesTool.h")]
public partial class UCSGMeshesTool : UBaseCreateFromSelectedTool {
	public static UClass StaticClass() {return default;}
	///<summary>CSGProperties</summary>
	public UCSGMeshesToolProperties CSGProperties;
	///<summary>TrimProperties</summary>
	public UTrimMeshesToolProperties TrimProperties;
	///<summary>OriginalMeshPreviews</summary>
	public TArray<UPreviewMesh> OriginalMeshPreviews;
	///<summary>Material used to show the otherwise-invisible cutting/trimming mesh</summary>
	public UMaterialInstanceDynamic PreviewsGhostMaterial;
	///<summary>DrawnLineSet</summary>
	public ULineSetComponent DrawnLineSet;
}
