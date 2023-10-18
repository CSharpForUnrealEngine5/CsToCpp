namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a null audio capture implementation which skips capturing audio. The MovieSceneCapture is explicitly</summary>
[CppInclude("Protocols/AudioCaptureProtocol.h")]
public partial class UNullAudioCaptureProtocol : UMovieSceneAudioCaptureProtocolBase {
	public static UClass StaticClass() {return default;}
}
