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
