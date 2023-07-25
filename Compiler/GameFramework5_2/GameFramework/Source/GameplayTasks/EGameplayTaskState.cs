#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask.h")]
public enum EGameplayTaskState {
	Uninitialized=0,
	AwaitingActivation=1,
	Paused=2,
	Active=3,
	Finished=4,
}
