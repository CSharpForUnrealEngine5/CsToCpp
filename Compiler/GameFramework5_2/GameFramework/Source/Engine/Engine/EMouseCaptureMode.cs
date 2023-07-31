#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineBaseTypes.h")]
public enum EMouseCaptureMode {
	NoCapture=0,
	CapturePermanently=1,
	CapturePermanently_IncludingInitialMouseDown=2,
	CaptureDuringMouseDown=3,
	CaptureDuringRightMouseDown=4,
}
