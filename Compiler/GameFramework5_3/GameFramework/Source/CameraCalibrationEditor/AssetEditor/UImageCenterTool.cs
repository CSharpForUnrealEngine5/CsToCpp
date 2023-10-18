namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UImageCenterTool is the controller for the image center panel.</summary>
[CppInclude("AssetEditor/ImageCenterTool.h")]
public partial class UImageCenterTool : UCameraCalibrationStep {
	public static UClass StaticClass() {return default;}
	///<summary>The currently selected algorithm</summary>
	public UCameraImageCenterAlgo CurrentAlgo;
	///<summary>Map of algo names to overlay MIDs used by those algos</summary>
	public TMap<FName,UMaterialInstanceDynamic> AlgoOverlayMIDs;
}
