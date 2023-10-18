namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Element Paint Tool Class</summary>
[CppInclude("ChaosClothAsset/ClothWeightMapPaintTool.h")]
public partial class UClothEditorWeightMapPaintTool : UMeshSculptToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>Filters on paint brush</summary>
	public UClothEditorWeightMapPaintBrushFilterProperties FilterProperties;
	///<summary>PaintBrushOpProperties</summary>
	public UWeightMapPaintBrushOpProps PaintBrushOpProperties;
	///<summary>SmoothBrushOpProperties</summary>
	public UWeightMapSmoothBrushOpProps SmoothBrushOpProperties;
	///<summary>EraseBrushOpProperties</summary>
	public UWeightMapEraseBrushOpProps EraseBrushOpProperties;
	///<summary>ActionsProps</summary>
	public UClothEditorMeshWeightMapPaintToolActions ActionsProps;
	///<summary>UpdateWeightMapProperties</summary>
	public UClothEditorUpdateWeightMapProperties UpdateWeightMapProperties;
	///<summary>PolyLassoMechanic</summary>
	public UPolyLassoMarqueeMechanic PolyLassoMechanic;
	///<summary>Gradient Support</summary>
	public UPolygonSelectionMechanic PolygonSelectionMechanic;
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>MeshElementsDisplay</summary>
	public UMeshElementsVisualizer MeshElementsDisplay;
	///<summary>ClothEditorContextObject</summary>
	public UClothEditorContextObject ClothEditorContextObject;
}
