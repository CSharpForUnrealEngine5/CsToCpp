#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraCalibrationSubsystem.h")]
///<summary>Camera Calibration subsystem</summary>
public partial class UCameraCalibrationSubsystem : UEngineSubsystem {
// CameraCalibrationSubsystem
	public UObject GetDefaultLensFile() { return default; }
	public void SetDefaultLensFile(UObject NewDefaultLensFile) {}
	public UObject GetLensFile(FLensFilePicker Picker) { return default; }
	public TArray<UObject> GetDistortionModelHandlers(UObject Component) { return default; }
	public UObject FindDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,bool bUpdatePicker/*=true*/) { return default; }
	public UObject FindOrCreateDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,UClass LensModelClass) { return default; }
	public void UnregisterDistortionModelHandler(UObject Component,UObject Handler) {}
	public UClass GetRegisteredLensModel(string ModelName) { return default; }
	public UClass GetCameraNodalOffsetAlgo(string Name) { return default; }
	public TArray<string> GetCameraNodalOffsetAlgos() { return default; }
	public UClass GetCameraImageCenterAlgo(string Name) { return default; }
	public TArray<string> GetCameraImageCenterAlgos() { return default; }
	public UObject GetOverlayMaterial(string OverlayName) { return default; }
	public TArray<string> GetOverlayMaterialNames() { return default; }
	public TArray<string> GetCameraCalibrationSteps() { return default; }
	public UClass GetCameraCalibrationStep(string Name) { return default; }
	public ULensFile DefaultLensFile;
	public TMap<string,UClass> LensModelMap;
	public TMap<string,UClass> CameraNodalOffsetAlgosMap;
	public TMap<string,UClass> CameraImageCenterAlgosMap;
	public TMap<string,UClass> CameraCalibrationStepsMap;
}
