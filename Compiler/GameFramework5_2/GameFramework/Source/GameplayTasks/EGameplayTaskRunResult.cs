#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTasksComponent.h")]
public enum EGameplayTaskRunResult {
	Error=0,
	Failed=1,
	Success_Paused=2,
	Success_Active=3,
	Success_Finished=4,
}
