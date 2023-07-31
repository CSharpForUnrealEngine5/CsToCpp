#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothWeightMapPaintTool.h")]
public partial class UClothEditorWeightMapPaintBrushFilterProperties : UInteractiveToolPropertySet {
	///<summary>Primary Brush Mode //UPROPERTY(EditAnywhere, Category = Brush2, meta = (DisplayName = &quot;Brush Type&quot;))</summary>
	public EClothEditorWeightMapPaintInteractionType SubToolType;
	///<summary>PrimaryBrushType</summary>
	public EClothEditorWeightMapPaintBrushType PrimaryBrushType;
	///<summary>Relative size of brush</summary>
	public float BrushSize;
	///<summary>The weight value that will be assigned to vertices</summary>
	public double StrengthValue;
	///<summary>The Region affected by the current operation will be bounded by edge angles larger than this threshold</summary>
	public float AngleThreshold;
	///<summary>The Region affected by the current operation will be bounded by UV borders/seams</summary>
	public bool bUVSeams;
	///<summary>The Region affected by the current operation will be bounded by Hard Normal edges/seams</summary>
	public bool bNormalSeams;
	///<summary>Control which triangles can be affected by the current operation based on visibility. Applied after all other filters.</summary>
	public EClothEditorWeightMapPaintVisibilityType VisibilityFilter;
}
