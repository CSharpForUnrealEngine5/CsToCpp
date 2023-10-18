namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StateTree event with payload.</summary>
[CppInclude("StateTreeEvents.h")]
public partial struct FStateTreeEvent {
	public FGameplayTag Tag;
	public FInstancedStruct Payload;
	public FName Origin;
}
