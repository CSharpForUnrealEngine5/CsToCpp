namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputTriggers.h")]
///<summary>Trigger states are a light weight interpretation of the provided input values used in trigger UpdateState responses.</summary>
public enum ETriggerState {
	None=0,
	Ongoing=1,
	Triggered=2,
}
