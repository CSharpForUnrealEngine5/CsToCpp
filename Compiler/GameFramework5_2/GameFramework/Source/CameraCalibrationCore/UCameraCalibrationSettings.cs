#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the CameraCalibration plugin modules.</summary>
[CppInclude("CameraCalibrationSettings.h")]
public partial class UCameraCalibrationSettings : UDeveloperSettings {
	///<summary>Startup lens file for the project</summary>
	public TSoftObjectPtr<ULensFile> StartupLensFile;
	///<summary>Resolution used when creating new distortion and undistortion displacement maps</summary>
	public FIntPoint DisplacementMapResolution;
	///<summary>Tolerance to use when adding or accessing data in a calibrated LensFile</summary>
	public float CalibrationInputTolerance;
	///<summary>Map of Lens Distortion Model Handler classes to the default displacement map material used by that class</summary>
	public TMap<UClass,TSoftObjectPtr<UMaterialInterface>> DefaultUndistortionDisplacementMaterials;
	///<summary>Map of Lens Distortion Model Handler classes to the default displacement map material used by that class</summary>
	public TMap<UClass,TSoftObjectPtr<UMaterialInterface>> DefaultDistortionDisplacementMaterials;
	///<summary>Map of Lens Distortion Model Handler classes to the default lens distortion post-process material used by that class</summary>
	public TMap<UClass,TSoftObjectPtr<UMaterialInterface>> DefaultDistortionMaterials;
	///<summary>Map of overlay names to override overlay materials</summary>
	public TMap<string,TSoftObjectPtr<UMaterialInterface>> CalibrationOverlayMaterialOverrides;
	///<summary>Setting to toggle the calibration dataset import and export features</summary>
	public bool bEnableCalibrationDatasetImportExport;
}
