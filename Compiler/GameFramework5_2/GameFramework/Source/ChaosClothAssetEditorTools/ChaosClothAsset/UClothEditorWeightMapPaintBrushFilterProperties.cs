#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothWeightMapPaintTool.h")]
public partial class UClothEditorWeightMapPaintBrushFilterProperties : UInteractiveToolPropertySet {
// ClothEditorWeightMapPaintBrushFilterProperties
	public EClothEditorWeightMapPaintInteractionType SubToolType;
	public EClothEditorWeightMapPaintBrushType PrimaryBrushType;
	public float BrushSize;
	public double StrengthValue;
	public float AngleThreshold;
	public bool bUVSeams;
	public bool bNormalSeams;
	public EClothEditorWeightMapPaintVisibilityType VisibilityFilter;
}
