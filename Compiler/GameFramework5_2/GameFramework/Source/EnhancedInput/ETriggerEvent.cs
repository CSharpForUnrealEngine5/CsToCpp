#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputTriggers.h")]
///<summary>Trigger events are the Action's interpretation of all Trigger State transitions that occurred for the action in the last tick</summary>
public enum ETriggerEvent {
	None=-1,
	Triggered=-1,
	Started=-1,
	Ongoing=-1,
	Canceled=-1,
	Completed=-1,
}
