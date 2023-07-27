#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraCalibrationSubsystem.h")]
///<summary>Camera Calibration subsystem</summary>
public partial class UCameraCalibrationSubsystem : UEngineSubsystem {
// CameraCalibrationSubsystem
	public  ULensFile GetDefaultLensFile() { return default; }
	public  void SetDefaultLensFile(ULensFile NewDefaultLensFile) {}
	public  ULensFile GetLensFile(FLensFilePicker Picker) { return default; }
	public  TArray<ULensDistortionModelHandlerBase> GetDistortionModelHandlers(UCineCameraComponent Component) { return default; }
	public  ULensDistortionModelHandlerBase FindDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,bool bUpdatePicker/*=true*/) { return default; }
	public  ULensDistortionModelHandlerBase FindOrCreateDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,UClass LensModelClass) { return default; }
	public  void UnregisterDistortionModelHandler(UCineCameraComponent Component,ULensDistortionModelHandlerBase Handler) {}
	public  UClass GetRegisteredLensModel(string ModelName) { return default; }
	public  UClass GetCameraNodalOffsetAlgo(string Name) { return default; }
	public  TArray<string> GetCameraNodalOffsetAlgos() { return default; }
	public  UClass GetCameraImageCenterAlgo(string Name) { return default; }
	public  TArray<string> GetCameraImageCenterAlgos() { return default; }
	public  UMaterialInterface GetOverlayMaterial(string OverlayName) { return default; }
	public  TArray<string> GetOverlayMaterialNames() { return default; }
	public  TArray<string> GetCameraCalibrationSteps() { return default; }
	public  UClass GetCameraCalibrationStep(string Name) { return default; }
	public ULensFile DefaultLensFile;
	public TMap<string,UClass> LensModelMap;
	public TMap<string,UClass> CameraNodalOffsetAlgosMap;
	public TMap<string,UClass> CameraImageCenterAlgosMap;
	public TMap<string,UClass> CameraCalibrationStepsMap;
}
