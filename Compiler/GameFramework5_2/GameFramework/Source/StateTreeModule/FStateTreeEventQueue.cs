#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event queue buffering all the events to be processed by a State Tree.</summary>
[CppInclude("StateTreeEvents.h")]
public partial struct FStateTreeEventQueue {
	public TArray<FStateTreeEvent> Events;
}
