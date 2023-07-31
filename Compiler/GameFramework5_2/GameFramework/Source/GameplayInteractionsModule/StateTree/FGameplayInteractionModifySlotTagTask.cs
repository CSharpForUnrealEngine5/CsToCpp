#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to modify Smart Object Slot tags.</summary>
[CppInclude("StateTree/GameplayInteractionModifySlotTagTask.h")]
public partial struct FGameplayInteractionModifySlotTagTask {
	public EGameplayInteractionTaskModify Modify;
	public EGameplayInteractionModifyGameplayTagOperation Operation;
	public FGameplayTag Tag;
}
