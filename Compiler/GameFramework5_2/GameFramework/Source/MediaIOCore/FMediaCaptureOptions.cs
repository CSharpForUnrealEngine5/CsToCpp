#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaCapture.h")]
///<summary>Base class of additional data that can be stored for each requested capture.</summary>
public partial struct FMediaCaptureOptions {
// MediaCaptureOptions
	public bool bAutoRestartOnSourceSizeChange;
	public EMediaCaptureOverrunAction OverrunAction;
	public EMediaCaptureCroppingType Crop;
	public FIntPoint CustomCapturePoint;
	public bool bResizeSourceBuffer;
	public bool bSkipFrameWhenRunningExpensiveTasks;
	public bool bConvertToDesiredPixelFormat;
	public bool bForceAlphaToOneOnConversion;
	public bool bApplyLinearToSRGBConversion;
	public bool bAutostopOnCapture;
	public int NumberOfFramesToCapture;
	public EMediaCapturePhase CapturePhase;
}
