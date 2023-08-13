namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputTriggers.h")]
///<summary>Trigger type determine how the trigger contributes to an action&#39;s overall trigger event the behavior of the trigger</summary>
public enum ETriggerType {
	Explicit=0,
	Implicit=1,
	Blocker=2,
}
