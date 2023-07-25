#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaCapture.h")]
///<summary>Possible states of media capture.</summary>
public enum EMediaCaptureState {
	Error=0,
	Capturing=1,
	Preparing=2,
	StopRequested=3,
	Stopped=4,
}
