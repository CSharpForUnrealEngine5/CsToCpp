#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AITypes.h")]
[CppEnumInNamespace]
public enum EPawnActionEventType {
	Invalid=0,
	FailedToStart=1,
	InstantAbort=2,
	FinishedAborting=3,
	FinishedExecution=4,
	Push=5,
}
