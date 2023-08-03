#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EyeTrackerFunctionLibrary.h")]
public partial class UEyeTrackerFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns whether or not the eye-tracking hardware is connected and ready to use. It may or may not actually be in use.</summary>
	public static bool IsEyeTrackerConnected() { return default; }
	///<summary>Returns whether or not the eye-tracking hardware is connected and ready to use. It may or may not actually be in use.</summary>
	public static bool IsStereoGazeDataAvailable() { return default; }
	///<summary>Returns unfied gaze data from the eye tracker. This is a single gaze ray, representing the fusion of both eyes.</summary>
	public static bool GetGazeData(FEyeTrackerGazeData OutGazeData) { return default; }
	///<summary>Returns stereo gaze data from the eye tracker. This includes a gaze ray per eye, as well as a fixation point.</summary>
	public static bool GetStereoGazeData(FEyeTrackerStereoGazeData OutGazeData) { return default; }
	///<summary>Specifies player being eye-tracked. This is not necessary for all devices, but is necessary for some to determine viewport properties, etc.</summary>
	public static void SetEyeTrackedPlayer(APlayerController PlayerController) {}
}
