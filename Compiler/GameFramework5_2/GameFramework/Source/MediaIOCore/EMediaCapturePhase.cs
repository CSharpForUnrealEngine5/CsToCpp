#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaCapture.h")]
public enum EMediaCapturePhase {
	BeforePostProcessing=0,
	AfterMotionBlur=1,
	AfterToneMap=2,
	AfterFXAA=3,
	EndFrame=4,
}
