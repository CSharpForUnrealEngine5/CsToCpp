#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Plane Cutting Tool</summary>
[CppInclude("CSGMeshesTool.h")]
public partial class UCSGMeshesTool : UBaseCreateFromSelectedTool {
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
