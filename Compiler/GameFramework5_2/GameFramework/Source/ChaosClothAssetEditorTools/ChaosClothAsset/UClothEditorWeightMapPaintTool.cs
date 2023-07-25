#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothWeightMapPaintTool.h")]
///<summary>Mesh Element Paint Tool Class</summary>
public partial class UClothEditorWeightMapPaintTool : UMeshSculptToolBase {
// ClothEditorWeightMapPaintTool
	public UWeightMapSetProperties WeightMapSetProperties;
	public UClothEditorWeightMapPaintBrushFilterProperties FilterProperties;
	public UWeightMapPaintBrushOpProps PaintBrushOpProperties;
	public UWeightMapEraseBrushOpProps EraseBrushOpProperties;
	public UMeshWeightMapPaintToolActions ActionsProps;
	public UClothEditorWeightMapActions ClothEditorWeightMapActions;
	public UPolyLassoMarqueeMechanic PolyLassoMechanic;
	public AInternalToolFrameworkActor PreviewMeshActor;
	public UDynamicMeshComponent DynamicMeshComponent;
	public UMeshElementsVisualizer MeshElementsDisplay;
}
