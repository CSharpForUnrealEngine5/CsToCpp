#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public enum ETimedDataMonitorEvaluationState {
	NoSample=0,
	OutsideRange=1,
	InsideRange=2,
	Disabled=3,
}
