#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraCalibrationSettings.h")]
///<summary>Settings for the CameraCalibration plugin modules.</summary>
public partial class UCameraCalibrationSettings : UDeveloperSettings {
// CameraCalibrationSettings
	public TSoftObjectPtr<ULensFile> StartupLensFile;
	public FIntPoint DisplacementMapResolution;
	public float CalibrationInputTolerance;
	public TMap<UClass,TSoftObjectPtr<UMaterialInterface>> DefaultUndistortionDisplacementMaterials;
	public TMap<UClass,TSoftObjectPtr<UMaterialInterface>> DefaultDistortionDisplacementMaterials;
	public TMap<UClass,TSoftObjectPtr<UMaterialInterface>> DefaultDistortionMaterials;
	public TMap<string,TSoftObjectPtr<UMaterialInterface>> CalibrationOverlayMaterialOverrides;
	public bool bEnableCalibrationDatasetImportExport;
}
