#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVBlueprintFunctionLibrary.h")]
public partial class UOpenCVBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// OpenCVBlueprintFunctionLibrary
	public int OpenCVChessboardDetectCorners(UObject InRenderTarget,FIntPoint InPatternSize,bool bDebugDrawCorners,UObject OutDebugTexture,TArray<FVector2D> OutDetectedCorners) { return default; }
	public int OpenCVArucoDetectMarkers(UObject InRenderTarget,EOpenCVArucoDictionary InDictionary,EOpenCVArucoDictionarySize InDictionarySize,bool bDebugDrawMarkers,bool bEstimatePose,float InMarkerLengthInMeters,FOpenCVLensDistortionParametersBase InLensDistortionParameters,UObject OutDebugTexture,TArray<FOpenCVArucoDetectedMarker> OutDetectedMarkers) { return default; }
}
