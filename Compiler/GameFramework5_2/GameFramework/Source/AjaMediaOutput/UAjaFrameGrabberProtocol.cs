namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AjaMediaFrameGrabberProtocol.h")]
public partial class UAjaFrameGrabberProtocol : UMovieSceneImageCaptureProtocolBase {
	public static UClass StaticClass() {return default;}
	///<summary>AJA Setting to use for the FrameGrabberProtocol</summary>
	public FSoftObjectPath MediaOutput;
	///<summary>States unused options for AJAFrameGrabberProtocolSettings</summary>
	public string Information;
	///<summary>Transient media output pointer to keep the media output alive while this protocol is in use</summary>
	public UAjaMediaOutput TransientMediaOutputPtr;
	///<summary>Transient media capture pointer that will capture the viewport</summary>
	public UAjaMediaCapture TransientMediaCapturePtr;
}
