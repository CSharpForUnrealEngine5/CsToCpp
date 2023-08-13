namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothTransferSkinWeightsTool.h")]
public partial class UClothTransferSkinWeightsTool : USingleSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>ToolProperties</summary>
	public UClothTransferSkinWeightsToolProperties ToolProperties;
	///<summary>ActionProperties</summary>
	public UClothTransferSkinWeightsToolActionProperties ActionProperties;
	///<summary>ClothComponent</summary>
	public UChaosClothComponent ClothComponent;
}
