#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Camera Calibration subsystem</summary>
[CppInclude("CameraCalibrationSubsystem.h")]
public partial class UCameraCalibrationSubsystem : UEngineSubsystem {
	///<summary>Get the default lens file.</summary>
	public  ULensFile GetDefaultLensFile() { return default; }
	///<summary>Get the default lens file.</summary>
	public  void SetDefaultLensFile(ULensFile NewDefaultLensFile) {}
	///<summary>Facilitator around the picker to get the desired lens file.</summary>
	public  ULensFile GetLensFile(FLensFilePicker Picker) { return default; }
	///<summary>GetDistortionModelHandlers</summary>
	public  TArray<ULensDistortionModelHandlerBase> GetDistortionModelHandlers(UCineCameraComponent Component) { return default; }
	///<summary>FindDistortionModelHandler</summary>
	public  ULensDistortionModelHandlerBase FindDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,bool bUpdatePicker/*=true*/) { return default; }
	///<summary>FindOrCreateDistortionModelHandler</summary>
	public  ULensDistortionModelHandlerBase FindOrCreateDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,UClass LensModelClass) { return default; }
	///<summary>UnregisterDistortionModelHandler</summary>
	public  void UnregisterDistortionModelHandler(UCineCameraComponent Component,ULensDistortionModelHandlerBase Handler) {}
	///<summary>Return the ULensModel subclass that was registered with the input model name</summary>
	public  UClass GetRegisteredLensModel(string ModelName) { return default; }
	///<summary>Returns the nodal offset algorithm by name</summary>
	public  UClass GetCameraNodalOffsetAlgo(string Name) { return default; }
	///<summary>Returns an array with the names of the available nodal offset algorithms</summary>
	public  TArray<string> GetCameraNodalOffsetAlgos() { return default; }
	///<summary>Returns the image center algorithm by name</summary>
	public  UClass GetCameraImageCenterAlgo(string Name) { return default; }
	///<summary>Returns an array with the names of the available image center algorithms</summary>
	public  TArray<string> GetCameraImageCenterAlgos() { return default; }
	///<summary>Returns the overlay material associated with the input overlay name</summary>
	public  UMaterialInterface GetOverlayMaterial(string OverlayName) { return default; }
	///<summary>Returns a list of all overlays known to the subsystem</summary>
	public  TArray<string> GetOverlayMaterialNames() { return default; }
	///<summary>Returns an array with the names of the available camera calibration steps</summary>
	public  TArray<string> GetCameraCalibrationSteps() { return default; }
	///<summary>Returns the camera calibration step by name</summary>
	public  UClass GetCameraCalibrationStep(string Name) { return default; }
	///<summary>Default lens file to use when no override has been provided</summary>
	public ULensFile DefaultLensFile;
	///<summary>Map of model names to ULensModel subclasses</summary>
	public TMap<string,UClass> LensModelMap;
	///<summary>Holds the registered camera nodal offset algos</summary>
	public TMap<string,UClass> CameraNodalOffsetAlgosMap;
	///<summary>Holds the registered camera image center algos</summary>
	public TMap<string,UClass> CameraImageCenterAlgosMap;
	///<summary>Holds the registered camera calibration steps</summary>
	public TMap<string,UClass> CameraCalibrationStepsMap;
}
