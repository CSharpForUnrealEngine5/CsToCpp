#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StateTree event with payload.</summary>
[CppInclude("StateTreeEvents.h")]
public partial struct FStateTreeEvent {
	public FGameplayTag Tag;
	public FInstancedStruct Payload;
	public string Origin;
}
