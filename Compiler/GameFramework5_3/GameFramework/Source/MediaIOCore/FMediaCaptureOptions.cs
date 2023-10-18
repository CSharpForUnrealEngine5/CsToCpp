namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of additional data that can be stored for each requested capture.</summary>
[CppInclude("MediaCapture.h")]
public partial struct FMediaCaptureOptions {
	public bool bAutoRestartOnSourceSizeChange;
	public EMediaCaptureOverrunAction OverrunAction;
	public EMediaCaptureCroppingType Crop;
	public FOpenColorIOColorConversionSettings ColorConversionSettings;
	public FIntPoint CustomCapturePoint;
	public EMediaCaptureResizeMethod ResizeMethod;
	public bool bSkipFrameWhenRunningExpensiveTasks;
	public bool bConvertToDesiredPixelFormat;
	public bool bForceAlphaToOneOnConversion;
	public bool bApplyLinearToSRGBConversion;
	public bool bAutostopOnCapture;
	public int NumberOfFramesToCapture;
	public EMediaCapturePhase CapturePhase;
	public bool bResizeSourceBuffer_DEPRECATED;
}
