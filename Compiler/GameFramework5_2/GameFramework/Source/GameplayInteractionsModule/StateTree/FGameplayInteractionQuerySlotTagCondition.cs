#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTree/GameplayInteractionConditions.h")]
///<summary>Condition to check if Gameplay Tags on a Smart Object slot match the Gameplay Tag query.</summary>
public partial struct FGameplayInteractionQuerySlotTagCondition {
// GameplayInteractionQuerySlotTagCondition
	public EGameplayInteractionMatchSlotTagSource Source;
	public FGameplayTagQuery TagQuery;
	public bool bInvert;
}
