#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensDistortionBlueprintLibrary.h")]
public partial class ULensDistortionBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the overscan factor required for the undistort rendering to avoid unrendered distorted pixels.</summary>
	public static void GetUndistortOverscanFactor(FLensDistortionCameraModel CameraModel,float DistortedHorizontalFOV,float DistortedAspectRatio,float UndistortOverscanFactor) {}
	///<summary>Draws UV displacement map within the output render target.</summary>
	public static void DrawUVDisplacementToRenderTarget(UObject WorldContextObject,FLensDistortionCameraModel CameraModel,float DistortedHorizontalFOV,float DistortedAspectRatio,float UndistortOverscanFactor,UTextureRenderTarget2D OutputRenderTarget,float OutputMultiply/*=0.5f*/,float OutputAdd/*=0.5f*/) {}
	///<summary>Returns true if A is equal to B (A == B)</summary>
	public static bool EqualEqual_CompareLensDistortionModels(FLensDistortionCameraModel A,FLensDistortionCameraModel B) { return default; }
	///<summary>Returns true if A is not equal to B (A != B)</summary>
	public static bool NotEqual_CompareLensDistortionModels(FLensDistortionCameraModel A,FLensDistortionCameraModel B) { return default; }
}
