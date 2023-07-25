#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshGroupPaintTool.h")]
///<summary>Mesh Element Paint Tool Class</summary>
public partial class UMeshGroupPaintTool : UMeshSculptToolBase {
// MeshGroupPaintTool
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public UGroupPaintBrushFilterProperties FilterProperties;
	public UGroupPaintBrushOpProps PaintBrushOpProperties;
	public UGroupEraseBrushOpProps EraseBrushOpProperties;
	public UMeshGroupPaintToolFreezeActions FreezeActions;
	public UPolyLassoMarqueeMechanic PolyLassoMechanic;
	public AInternalToolFrameworkActor PreviewMeshActor;
	public UDynamicMeshComponent DynamicMeshComponent;
	public UMeshElementsVisualizer MeshElementsDisplay;
}
