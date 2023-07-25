#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeEvents.h")]
///<summary>StateTree event with payload.</summary>
public partial struct FStateTreeEvent {
// StateTreeEvent
	public FGameplayTag Tag;
	public FInstancedStruct Payload;
	public string Origin;
}
