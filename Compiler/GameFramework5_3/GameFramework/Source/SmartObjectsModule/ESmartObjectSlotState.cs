namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectRuntime.h")]
///<summary>Enumeration to represent the runtime state of a slot</summary>
public enum ESmartObjectSlotState {
	Invalid=0,
	Free=1,
	Claimed=2,
	Occupied=3,
	Disabled=4,
}
