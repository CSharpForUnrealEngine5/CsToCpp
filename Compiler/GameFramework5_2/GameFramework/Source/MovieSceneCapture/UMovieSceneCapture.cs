#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class responsible for capturing scene data</summary>
[CppInclude("MovieSceneCapture.h")]
public partial class UMovieSceneCapture : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The type of capture protocol to use for image data</summary>
	public FSoftClassPath ImageCaptureProtocolType;
	///<summary>The type of capture protocol to use for audio data.</summary>
	public FSoftClassPath AudioCaptureProtocolType;
	///<summary>Capture protocol responsible for actually capturing frame data</summary>
	public UMovieSceneImageCaptureProtocolBase ImageCaptureProtocol;
	///<summary>AudioCaptureProtocol</summary>
	public UMovieSceneAudioCaptureProtocolBase AudioCaptureProtocol;
	///<summary>Settings that define how to capture</summary>
	public FMovieSceneCaptureSettings Settings;
	///<summary>Whether to capture the movie in a separate process or not</summary>
	public bool bUseSeparateProcess;
	///<summary>When enabled, the editor will shutdown when the capture starts</summary>
	public bool bCloseEditorWhenCaptureStarts;
	///<summary>Additional command line arguments to pass to the external process when capturing</summary>
	public string AdditionalCommandLineArguments;
	///<summary>Command line arguments inherited from this process</summary>
	public string InheritedCommandLineArguments;
	///<summary>Access the capture protocol we are using</summary>
	public  UMovieSceneCaptureProtocolBase GetImageCaptureProtocol() { return default; }
	///<summary>GetAudioCaptureProtocol</summary>
	public  UMovieSceneCaptureProtocolBase GetAudioCaptureProtocol() { return default; }
	///<summary>SetImageCaptureProtocolType</summary>
	public  void SetImageCaptureProtocolType(UClass ProtocolType) {}
	///<summary>SetAudioCaptureProtocolType</summary>
	public  void SetAudioCaptureProtocolType(UClass ProtocolType) {}
}
