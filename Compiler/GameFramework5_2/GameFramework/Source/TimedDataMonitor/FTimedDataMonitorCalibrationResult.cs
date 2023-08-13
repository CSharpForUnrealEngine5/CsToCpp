namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorCalibration.h")]
public partial struct FTimedDataMonitorCalibrationResult {
	public ETimedDataMonitorCalibrationReturnCode ReturnCode;
	public TArray<FTimedDataMonitorInputIdentifier> FailureInputIdentifiers;
}
