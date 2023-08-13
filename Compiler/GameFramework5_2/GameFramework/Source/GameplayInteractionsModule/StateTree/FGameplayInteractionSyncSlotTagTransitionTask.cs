namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to monitor transition of a Gameplay Tag on the specified Smart Object slot.</summary>
[CppInclude("StateTree/GameplayInteractionSyncSlotTagTransition.h")]
public partial struct FGameplayInteractionSyncSlotTagTransitionTask {
	public FGameplayTag TransitionFromTag;
	public FGameplayTag TransitionToTag;
	public FGameplayTag TransitionEventTag;
}
