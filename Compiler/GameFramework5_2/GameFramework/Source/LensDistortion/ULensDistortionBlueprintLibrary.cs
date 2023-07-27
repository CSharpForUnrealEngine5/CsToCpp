#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensDistortionBlueprintLibrary.h")]
public partial class ULensDistortionBlueprintLibrary : UBlueprintFunctionLibrary {
// LensDistortionBlueprintLibrary
	public static void GetUndistortOverscanFactor(FLensDistortionCameraModel CameraModel,float DistortedHorizontalFOV,float DistortedAspectRatio,float UndistortOverscanFactor) {}
	public static void DrawUVDisplacementToRenderTarget(UObject WorldContextObject,FLensDistortionCameraModel CameraModel,float DistortedHorizontalFOV,float DistortedAspectRatio,float UndistortOverscanFactor,UTextureRenderTarget2D OutputRenderTarget,float OutputMultiply/*=0.5f*/,float OutputAdd/*=0.5f*/) {}
	public static bool EqualEqual_CompareLensDistortionModels(FLensDistortionCameraModel A,FLensDistortionCameraModel B) { return default; }
	public static bool NotEqual_CompareLensDistortionModels(FLensDistortionCameraModel A,FLensDistortionCameraModel B) { return default; }
}
