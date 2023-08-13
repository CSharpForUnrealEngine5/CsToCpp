namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVLensDistortionBlueprintLibrary.h")]
public partial class UOpenCVLensDistortionBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Draws UV displacement map within the output render target.</summary>
	public static void DrawDisplacementMapToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D OutputRenderTarget,UTexture2D PreComputedUndistortDisplacementMap) {}
	///<summary>Creates a texture containing a DisplacementMap in the Red and the Green channel for undistorting a camera image.</summary>
	public static UTexture2D CreateUndistortUVDisplacementMap(FOpenCVLensDistortionParameters LensParameters,FIntPoint ImageSize,float CroppingFactor,FOpenCVCameraViewInfo CameraViewInfo) { return default; }
	///<summary>Returns true if A is equal to B (A == B)</summary>
	public static bool EqualEqual_CompareLensDistortionModels(FOpenCVLensDistortionParameters A,FOpenCVLensDistortionParameters B) { return default; }
	///<summary>Returns true if A is not equal to B (A != B)</summary>
	public static bool NotEqual_CompareLensDistortionModels(FOpenCVLensDistortionParameters A,FOpenCVLensDistortionParameters B) { return default; }
}
