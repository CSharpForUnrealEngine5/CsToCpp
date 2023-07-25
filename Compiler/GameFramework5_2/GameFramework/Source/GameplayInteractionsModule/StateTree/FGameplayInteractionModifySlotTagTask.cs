#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTree/GameplayInteractionModifySlotTagTask.h")]
///<summary>Task to modify Smart Object Slot tags.</summary>
public partial struct FGameplayInteractionModifySlotTagTask {
// GameplayInteractionModifySlotTagTask
	public EGameplayInteractionTaskModify Modify;
	public EGameplayInteractionModifyGameplayTagOperation Operation;
	public FGameplayTag Tag;
}
