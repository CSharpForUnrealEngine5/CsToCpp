#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetEditor/ImageCenterTool.h")]
///<summary>UImageCenterTool is the controller for the image center panel.</summary>
public partial class UImageCenterTool : UCameraCalibrationStep {
// ImageCenterTool
	public UCameraImageCenterAlgo CurrentAlgo;
	public TMap<string,UMaterialInstanceDynamic> AlgoOverlayMIDs;
}
