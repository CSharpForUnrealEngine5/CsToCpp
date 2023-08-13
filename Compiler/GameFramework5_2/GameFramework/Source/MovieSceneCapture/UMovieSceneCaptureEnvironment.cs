namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneCaptureEnvironment.h")]
public partial class UMovieSceneCaptureEnvironment : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the frame number of the current capture</summary>
	public static int GetCaptureFrameNumber() { return default; }
	///<summary>Get the total elapsed time of the current capture in seconds</summary>
	public static float GetCaptureElapsedTime() { return default; }
	///<summary>Return true if there is any capture currently active (even in a warm-up state).</summary>
	public static bool IsCaptureInProgress() { return default; }
	///<summary>Attempt to locate a capture protocol - may not be in a capturing state</summary>
	public static UMovieSceneImageCaptureProtocolBase FindImageCaptureProtocol() { return default; }
	///<summary>Attempt to locate a capture protocol - may not be in a capturing state</summary>
	public static UMovieSceneAudioCaptureProtocolBase FindAudioCaptureProtocol() { return default; }
}
