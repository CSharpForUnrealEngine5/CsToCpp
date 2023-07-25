#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EyeTrackerFunctionLibrary.h")]
public partial class UEyeTrackerFunctionLibrary : UBlueprintFunctionLibrary {
// EyeTrackerFunctionLibrary
	public bool IsEyeTrackerConnected() { return default; }
	public bool IsStereoGazeDataAvailable() { return default; }
	public bool GetGazeData(FEyeTrackerGazeData OutGazeData) { return default; }
	public bool GetStereoGazeData(FEyeTrackerStereoGazeData OutGazeData) { return default; }
	public void SetEyeTrackedPlayer(UObject PlayerController) {}
}
