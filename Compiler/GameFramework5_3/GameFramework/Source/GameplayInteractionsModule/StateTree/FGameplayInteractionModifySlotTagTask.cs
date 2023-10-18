namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to modify Smart Object Slot tags.</summary>
[CppInclude("StateTree/GameplayInteractionModifySlotTagTask.h")]
public partial struct FGameplayInteractionModifySlotTagTask {
	public EGameplayInteractionTaskModify Modify;
	public bool bHandleExternalStopAsFailure;
	public EGameplayInteractionModifyGameplayTagOperation Operation;
	public FGameplayTag Tag;
}
