#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public partial struct FTimedDataMonitorTimeCorrectionResult {
	public ETimedDataMonitorTimeCorrectionReturnCode ReturnCode;
	public TArray<FTimedDataMonitorChannelIdentifier> FailureChannelIdentifiers;
}
