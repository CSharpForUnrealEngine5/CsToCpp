#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorEditorSettings.h")]
public partial class UTimedDataMonitorEditorSettings : UObject {
	///<summary>Option to use when calibrating from the UI.</summary>
	public FTimedDataMonitorCalibrationParameters CalibrationSettings;
	///<summary>Option to use when calibrating from the UI.</summary>
	public FTimedDataMonitorTimeCorrectionParameters TimeCorrectionSettings;
	///<summary>At which speed we should update the Timed Data Monitor UI.</summary>
	public float RefreshRate;
	///<summary>Whether or not to draw vertical bars delineating each frame in the buffer of a channel</summary>
	public bool bDrawFrameTimesInBufferVisualization;
	///<summary>If true, accurate world times will be used to draw frame times. If false, a constant frame interval is used</summary>
	public bool bUseAccurateFrameTimesInBufferVisualization;
	///<summary>bOverrideNumberOfStandardDeviationToShow</summary>
	public bool bOverrideNumberOfStandardDeviationToShow;
	///<summary>When displaying the buffer widget, how many STD should we show.</summary>
	public int OverrideNumberOfStandardDeviationToShow;
	///<summary>The threshold at which to display the frame time as orange.</summary>
	public double FrameTimeWarnThreshold;
	///<summary>The percent at which to display the target frame time in the frame time indicator.</summary>
	public double TargetFrameTimePercent;
	///<summary>LastCalibrationType</summary>
	public ETimedDataMonitorEditorCalibrationType LastCalibrationType;
	///<summary>The Reset button will reset the buffer errors count.</summary>
	public bool bResetBufferStatEnabled;
	///<summary>The Reset button will clear the messages list.</summary>
	public bool bClearMessageEnabled;
	///<summary>The Reset button will set the evaluation time of all input to 0.</summary>
	public bool bResetEvaluationTimeEnabled;
}
