namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public partial struct FTimedDataMonitorTimeCorrectionParameters {
	public bool bBufferResizeAllowed;
	public bool bBufferShrinkAllowed;
	public bool bFailedIfBufferCantBeResize;
	public bool bUseStandardDeviation;
	public int NumberOfStandardDeviation;
}
