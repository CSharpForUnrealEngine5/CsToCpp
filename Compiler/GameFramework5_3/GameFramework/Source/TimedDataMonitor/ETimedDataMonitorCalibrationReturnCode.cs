namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public enum ETimedDataMonitorCalibrationReturnCode {
	Succeeded=0,
	Failed_NoTimecode=1,
	Failed_UnresponsiveInput=2,
	Failed_InvalidEvaluationType=3,
	Failed_InvalidFrameRate=4,
	Failed_NoDataBuffered=5,
	Failed_BufferCouldNotBeResize=6,
	Failed_Reset=7,
	Retry_NotEnoughData=8,
	Retry_IncreaseBufferSize=9,
}
