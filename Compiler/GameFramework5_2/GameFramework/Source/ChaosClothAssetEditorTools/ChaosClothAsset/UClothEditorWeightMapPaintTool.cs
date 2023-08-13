namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Element Paint Tool Class</summary>
[CppInclude("ChaosClothAsset/ClothWeightMapPaintTool.h")]
public partial class UClothEditorWeightMapPaintTool : UMeshSculptToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>WeightMapSetProperties</summary>
	public UWeightMapSetProperties WeightMapSetProperties;
	///<summary>Filters on paint brush</summary>
	public UClothEditorWeightMapPaintBrushFilterProperties FilterProperties;
	///<summary>PaintBrushOpProperties</summary>
	public UWeightMapPaintBrushOpProps PaintBrushOpProperties;
	///<summary>EraseBrushOpProperties</summary>
	public UWeightMapEraseBrushOpProps EraseBrushOpProperties;
	///<summary>ActionsProps</summary>
	public UMeshWeightMapPaintToolActions ActionsProps;
	///<summary>ClothEditorWeightMapActions</summary>
	public UClothEditorWeightMapActions ClothEditorWeightMapActions;
	///<summary>PolyLassoMechanic</summary>
	public UPolyLassoMarqueeMechanic PolyLassoMechanic;
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>MeshElementsDisplay</summary>
	public UMeshElementsVisualizer MeshElementsDisplay;
}
