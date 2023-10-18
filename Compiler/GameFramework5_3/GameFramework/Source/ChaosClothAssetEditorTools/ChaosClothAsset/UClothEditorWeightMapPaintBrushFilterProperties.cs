namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO: Look at EditConditions for all these properties. Which ones make sense for which SubToolType?</summary>
[CppInclude("ChaosClothAsset/ClothWeightMapPaintTool.h")]
public partial class UClothEditorWeightMapPaintBrushFilterProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>SubToolType</summary>
	public EClothEditorWeightMapPaintInteractionType SubToolType;
	///<summary>PrimaryBrushType</summary>
	public EClothEditorWeightMapPaintBrushType PrimaryBrushType;
	///<summary>Relative size of brush</summary>
	public float BrushSize;
	///<summary>The new value to paint on the mesh</summary>
	public double AttributeValue;
	///<summary>How quickly each brush stroke will drive mesh values towards the desired value</summary>
	public double Strength;
	///<summary>The Gradient upper limit value</summary>
	public double GradientHighValue;
	///<summary>The Gradient lower limit value</summary>
	public double GradientLowValue;
	///<summary>The Region affected by the current operation will be bounded by edge angles larger than this threshold</summary>
	public float AngleThreshold;
	///<summary>The Region affected by the current operation will be bounded by UV borders/seams</summary>
	public bool bUVSeams;
	///<summary>The Region affected by the current operation will be bounded by Hard Normal edges/seams</summary>
	public bool bNormalSeams;
	///<summary>Control which triangles can be affected by the current operation based on visibility. Applied after all other filters.</summary>
	public EClothEditorWeightMapPaintVisibilityType VisibilityFilter;
	///<summary>The weight value at the brush indicator</summary>
	public double ValueAtBrush;
}
