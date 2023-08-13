namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothTrainingTool.h")]
public partial class UClothTrainingTool : USingleSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>ToolProperties</summary>
	public UClothTrainingToolProperties ToolProperties;
	///<summary>ActionProperties</summary>
	public UClothTrainingToolActionProperties ActionProperties;
	///<summary>ClothComponent</summary>
	public UChaosClothComponent ClothComponent;
}
