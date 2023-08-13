namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Element Paint Tool Class</summary>
[CppInclude("MeshGroupPaintTool.h")]
public partial class UMeshGroupPaintTool : UMeshSculptToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>Filters on paint brush</summary>
	public UGroupPaintBrushFilterProperties FilterProperties;
	///<summary>This will be of type UGroupPaintBrushOpProps, we keep a ref so we can change active group ID on pick</summary>
	public UGroupPaintBrushOpProps PaintBrushOpProperties;
	///<summary>EraseBrushOpProperties</summary>
	public UGroupEraseBrushOpProps EraseBrushOpProperties;
	///<summary>FreezeActions</summary>
	public UMeshGroupPaintToolFreezeActions FreezeActions;
	///<summary>PolyLassoMechanic</summary>
	public UPolyLassoMarqueeMechanic PolyLassoMechanic;
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>MeshElementsDisplay</summary>
	public UMeshElementsVisualizer MeshElementsDisplay;
}
