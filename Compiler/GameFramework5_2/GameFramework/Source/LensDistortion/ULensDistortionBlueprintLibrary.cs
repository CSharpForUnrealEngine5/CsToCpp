#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensDistortionBlueprintLibrary.h")]
public partial class ULensDistortionBlueprintLibrary : UBlueprintFunctionLibrary {
// LensDistortionBlueprintLibrary
	public void GetUndistortOverscanFactor(FLensDistortionCameraModel CameraModel,float DistortedHorizontalFOV,float DistortedAspectRatio,float UndistortOverscanFactor) {}
	public void DrawUVDisplacementToRenderTarget(UObject WorldContextObject,FLensDistortionCameraModel CameraModel,float DistortedHorizontalFOV,float DistortedAspectRatio,float UndistortOverscanFactor,UObject OutputRenderTarget,float OutputMultiply/*=0.5f*/,float OutputAdd/*=0.5f*/) {}
	public bool EqualEqual_CompareLensDistortionModels(FLensDistortionCameraModel A,FLensDistortionCameraModel B) { return default; }
	public bool NotEqual_CompareLensDistortionModels(FLensDistortionCameraModel A,FLensDistortionCameraModel B) { return default; }
}
