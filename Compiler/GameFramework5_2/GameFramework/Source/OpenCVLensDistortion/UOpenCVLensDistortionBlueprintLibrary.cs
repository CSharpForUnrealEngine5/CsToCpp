#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVLensDistortionBlueprintLibrary.h")]
public partial class UOpenCVLensDistortionBlueprintLibrary : UBlueprintFunctionLibrary {
// OpenCVLensDistortionBlueprintLibrary
	public static void DrawDisplacementMapToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D OutputRenderTarget,UTexture2D PreComputedUndistortDisplacementMap) {}
	public static UTexture2D CreateUndistortUVDisplacementMap(FOpenCVLensDistortionParameters LensParameters,FIntPoint ImageSize,float CroppingFactor,FOpenCVCameraViewInfo CameraViewInfo) { return default; }
	public static bool EqualEqual_CompareLensDistortionModels(FOpenCVLensDistortionParameters A,FOpenCVLensDistortionParameters B) { return default; }
	public static bool NotEqual_CompareLensDistortionModels(FOpenCVLensDistortionParameters A,FOpenCVLensDistortionParameters B) { return default; }
}
