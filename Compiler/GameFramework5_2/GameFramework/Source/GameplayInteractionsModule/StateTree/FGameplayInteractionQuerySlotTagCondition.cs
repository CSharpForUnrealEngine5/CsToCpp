#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Condition to check if Gameplay Tags on a Smart Object slot match the Gameplay Tag query.</summary>
[CppInclude("StateTree/GameplayInteractionConditions.h")]
public partial struct FGameplayInteractionQuerySlotTagCondition {
	public EGameplayInteractionMatchSlotTagSource Source;
	public FGameplayTagQuery TagQuery;
	public bool bInvert;
}
