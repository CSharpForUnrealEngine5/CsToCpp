namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Vertex Color Painting TOol</summary>
[CppInclude("MeshVertexPaintTool.h")]
public partial class UMeshVertexPaintTool : UMeshSculptToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>BasicProperties</summary>
	public UVertexPaintBasicProperties BasicProperties;
	///<summary>Filters on paint brush</summary>
	public UVertexPaintBrushFilterProperties FilterProperties;
	///<summary>This will be of type UVertexPaintBrushOpProps, we keep a ref so we can change active color on pick</summary>
	public UVertexColorPaintBrushOpProps PaintBrushOpProperties;
	///<summary>This will be of type UVertexPaintBrushOpProps, we keep a ref so we can change active color on pick</summary>
	public UVertexColorPaintBrushOpProps EraseBrushOpProperties;
	///<summary>QuickActions</summary>
	public UMeshVertexPaintToolQuickActions QuickActions;
	///<summary>UtilityActions</summary>
	public UMeshVertexPaintToolUtilityActions UtilityActions;
	///<summary>PolyLassoMechanic</summary>
	public UPolyLassoMarqueeMechanic PolyLassoMechanic;
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>MeshElementsDisplay</summary>
	public UMeshElementsVisualizer MeshElementsDisplay;
}
