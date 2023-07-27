#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EyeTrackerFunctionLibrary.h")]
public partial class UEyeTrackerFunctionLibrary : UBlueprintFunctionLibrary {
// EyeTrackerFunctionLibrary
	public static bool IsEyeTrackerConnected() { return default; }
	public static bool IsStereoGazeDataAvailable() { return default; }
	public static bool GetGazeData(FEyeTrackerGazeData OutGazeData) { return default; }
	public static bool GetStereoGazeData(FEyeTrackerStereoGazeData OutGazeData) { return default; }
	public static void SetEyeTrackedPlayer(APlayerController PlayerController) {}
}
