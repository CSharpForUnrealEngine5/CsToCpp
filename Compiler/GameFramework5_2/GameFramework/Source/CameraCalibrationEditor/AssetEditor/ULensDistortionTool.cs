#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetEditor/LensDistortionTool.h")]
///<summary>ULensDistortionTool is the controller for the lens distortion panel.</summary>
public partial class ULensDistortionTool : UCameraCalibrationStep {
// LensDistortionTool
	public UCameraLensDistortionAlgo CurrentAlgo;
	public TMap<string,UClass> AlgosMap;
	public TMap<string,UClass> SupportedAlgosMap;
	public TMap<string,UMaterialInstanceDynamic> AlgoOverlayMIDs;
}
