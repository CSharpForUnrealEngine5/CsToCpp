#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
///<summary>Base tool to create primitives</summary>
public partial class UAddPrimitiveTool : USingleClickTool {
// AddPrimitiveTool
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UProceduralShapeToolProperties ShapeSettings;
	public UNewMeshMaterialProperties MaterialProperties;
	public UPreviewMesh PreviewMesh;
	public UCombinedTransformGizmo Gizmo;
	public UDragAlignmentMechanic DragAlignmentMechanic;
	public string AssetName;
}
