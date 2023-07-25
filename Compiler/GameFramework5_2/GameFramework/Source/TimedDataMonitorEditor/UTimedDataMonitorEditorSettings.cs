#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorEditorSettings.h")]
public partial class UTimedDataMonitorEditorSettings : UObject {
// TimedDataMonitorEditorSettings
	public FTimedDataMonitorCalibrationParameters CalibrationSettings;
	public FTimedDataMonitorTimeCorrectionParameters TimeCorrectionSettings;
	public float RefreshRate;
	public bool bDrawFrameTimesInBufferVisualization;
	public bool bUseAccurateFrameTimesInBufferVisualization;
	public bool bOverrideNumberOfStandardDeviationToShow;
	public int OverrideNumberOfStandardDeviationToShow;
	public double FrameTimeWarnThreshold;
	public double TargetFrameTimePercent;
	public ETimedDataMonitorEditorCalibrationType LastCalibrationType;
	public bool bResetBufferStatEnabled;
	public bool bClearMessageEnabled;
	public bool bResetEvaluationTimeEnabled;
}
