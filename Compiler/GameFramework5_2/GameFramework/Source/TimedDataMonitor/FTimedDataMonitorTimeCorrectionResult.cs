namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public partial struct FTimedDataMonitorTimeCorrectionResult {
	public ETimedDataMonitorTimeCorrectionReturnCode ReturnCode;
	public TArray<FTimedDataMonitorChannelIdentifier> FailureChannelIdentifiers;
}
