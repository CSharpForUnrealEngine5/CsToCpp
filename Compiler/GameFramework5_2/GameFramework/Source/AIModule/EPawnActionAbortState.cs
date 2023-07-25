#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AITypes.h")]
[CppEnumInNamespace]
public enum EPawnActionAbortState {
	NeverStarted=0,
	NotBeingAborted=1,
	MarkPendingAbort=2,
	LatentAbortInProgress=3,
	AbortDone=4,
	MAX=5,
}
