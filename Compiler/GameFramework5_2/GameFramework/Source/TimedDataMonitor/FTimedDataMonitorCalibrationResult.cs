#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public partial struct FTimedDataMonitorCalibrationResult {
// TimedDataMonitorCalibrationResult
	public ETimedDataMonitorCalibrationReturnCode ReturnCode;
	public TArray<FTimedDataMonitorInputIdentifier> FailureInputIdentifiers;
}
