#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public partial struct FTimedDataMonitorTimeCorrectionResult {
// TimedDataMonitorTimeCorrectionResult
	public ETimedDataMonitorTimeCorrectionReturnCode ReturnCode;
	public TArray<FTimedDataMonitorChannelIdentifier> FailureChannelIdentifiers;
}
