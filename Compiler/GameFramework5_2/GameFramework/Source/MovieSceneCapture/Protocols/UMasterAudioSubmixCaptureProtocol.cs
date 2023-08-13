namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is an experimental audio capture implementation which captures the final output from the master submix.</summary>
[CppInclude("Protocols/AudioCaptureProtocol.h")]
public partial class UMasterAudioSubmixCaptureProtocol : UMovieSceneAudioCaptureProtocolBase {
	public static UClass StaticClass() {return default;}
	///<summary>FileName</summary>
	public string FileName;
}
