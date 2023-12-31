namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVBlueprintFunctionLibrary.h")]
public partial class UOpenCVBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Detects a camera calibration chessboard in the supplied image</summary>
	public static int OpenCVChessboardDetectCorners(UTextureRenderTarget2D InRenderTarget,FIntPoint InPatternSize,bool bDebugDrawCorners,UTexture2D OutDebugTexture,TArray<FVector2D> OutDetectedCorners) { return default; }
	///<summary>Detects all ArUco markers in the supplied image</summary>
	public static int OpenCVArucoDetectMarkers(UTextureRenderTarget2D InRenderTarget,EOpenCVArucoDictionary InDictionary,EOpenCVArucoDictionarySize InDictionarySize,bool bDebugDrawMarkers,bool bEstimatePose,float InMarkerLengthInMeters,FOpenCVLensDistortionParametersBase InLensDistortionParameters,UTexture2D OutDebugTexture,TArray<FOpenCVArucoDetectedMarker> OutDetectedMarkers) { return default; }
}
