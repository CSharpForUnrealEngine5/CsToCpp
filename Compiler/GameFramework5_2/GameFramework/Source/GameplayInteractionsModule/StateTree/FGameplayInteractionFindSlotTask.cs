namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to find a Smart Object slot based on a reference slot.</summary>
[CppInclude("StateTree/GameplayInteractionFindSlotTask.h")]
public partial struct FGameplayInteractionFindSlotTask {
	public EGameplayInteractionSlotReferenceType ReferenceType;
	public FGameplayTag FindByTag;
}
