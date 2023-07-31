#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public partial struct FTimedDataMonitorCalibrationParameters {
	public int NumberOfRetries;
	public bool bBufferResizeAllowed;
	public bool bBufferShrinkAllowed;
	public bool bFailedIfBufferCantBeResize;
	public bool bUseStandardDeviation;
	public int NumberOfStandardDeviation;
	public bool bResetStatisticsBeforeUsingStandardDeviation;
	public float AmountOfSecondsToWaitAfterStatisticReset;
}
