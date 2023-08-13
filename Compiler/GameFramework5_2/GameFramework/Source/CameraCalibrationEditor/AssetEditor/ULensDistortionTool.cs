namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULensDistortionTool is the controller for the lens distortion panel.</summary>
[CppInclude("AssetEditor/LensDistortionTool.h")]
public partial class ULensDistortionTool : UCameraCalibrationStep {
	public static UClass StaticClass() {return default;}
	///<summary>The currently selected algorithm</summary>
	public UCameraLensDistortionAlgo CurrentAlgo;
	///<summary>Holds the registered camera lens distortion algos</summary>
	public TMap<string,UClass> AlgosMap;
	///<summary>Holds a subset of the registered algos that support the current Lens Model</summary>
	public TMap<string,UClass> SupportedAlgosMap;
	///<summary>Map of algo names to overlay MIDs used by those algos</summary>
	public TMap<string,UMaterialInstanceDynamic> AlgoOverlayMIDs;
}
