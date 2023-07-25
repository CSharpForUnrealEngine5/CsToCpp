#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeEvents.h")]
///<summary>Event queue buffering all the events to be processed by a State Tree.</summary>
public partial struct FStateTreeEventQueue {
// StateTreeEventQueue
	public TArray<FStateTreeEvent> Events;
}
