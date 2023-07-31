#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of additional data that can be stored for each requested capture.</summary>
[CppInclude("MediaCapture.h")]
public partial struct FMediaCaptureOptions {
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
