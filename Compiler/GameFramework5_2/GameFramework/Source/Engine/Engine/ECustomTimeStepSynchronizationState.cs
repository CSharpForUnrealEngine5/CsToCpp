#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineCustomTimeStep.h")]
///<summary>Possible states of CustomTimeStep.</summary>
public enum ECustomTimeStepSynchronizationState {
	Closed=0,
	Error=1,
	Synchronized=2,
	Synchronizing=3,
}
