namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base tool to create primitives</summary>
[CppInclude("AddPrimitiveTool.h")]
public partial class UAddPrimitiveTool : USingleClickTool {
	public static UClass StaticClass() {return default;}
	///<summary>Property set for type of output object (StaticMesh, Volume, etc)</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>ShapeSettings</summary>
	public UProceduralShapeToolProperties ShapeSettings;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>Gizmo</summary>
	public UCombinedTransformGizmo Gizmo;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
	///<summary>AssetName</summary>
	public string AssetName;
}
