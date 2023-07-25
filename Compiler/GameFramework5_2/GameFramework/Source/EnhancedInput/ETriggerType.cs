#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputTriggers.h")]
///<summary>Trigger type determine how the trigger contributes to an action's overall trigger event the behavior of the trigger</summary>
public enum ETriggerType {
	Explicit=0,
	Implicit=1,
	Blocker=2,
}
