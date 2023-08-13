namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public enum ETimedDataMonitorTimeCorrectionReturnCode {
	Succeeded=0,
	Failed_InvalidInput=1,
	Failed_NoTimecode=2,
	Failed_UnresponsiveInput=3,
	Failed_NoDataBuffered=4,
	Failed_BufferCouldNotBeResize=5,
	Retry_NotEnoughData=6,
	Retry_IncreaseBufferSize=7,
}
