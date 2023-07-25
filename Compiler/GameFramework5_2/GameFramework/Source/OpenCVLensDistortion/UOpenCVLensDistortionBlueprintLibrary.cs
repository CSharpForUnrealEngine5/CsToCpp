#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVLensDistortionBlueprintLibrary.h")]
public partial class UOpenCVLensDistortionBlueprintLibrary : UBlueprintFunctionLibrary {
// OpenCVLensDistortionBlueprintLibrary
	public void DrawDisplacementMapToRenderTarget(UObject WorldContextObject,UObject OutputRenderTarget,UObject PreComputedUndistortDisplacementMap) {}
	public UObject CreateUndistortUVDisplacementMap(FOpenCVLensDistortionParameters LensParameters,FIntPoint ImageSize,float CroppingFactor,FOpenCVCameraViewInfo CameraViewInfo) { return default; }
	public bool EqualEqual_CompareLensDistortionModels(FOpenCVLensDistortionParameters A,FOpenCVLensDistortionParameters B) { return default; }
	public bool NotEqual_CompareLensDistortionModels(FOpenCVLensDistortionParameters A,FOpenCVLensDistortionParameters B) { return default; }
}
