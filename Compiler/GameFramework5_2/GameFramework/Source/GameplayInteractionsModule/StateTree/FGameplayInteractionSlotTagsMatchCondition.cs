#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTree/GameplayInteractionConditions.h")]
///<summary>Condition to check if Gameplay Tags on a Smart Object slot match the specified tags.</summary>
public partial struct FGameplayInteractionSlotTagsMatchCondition {
// GameplayInteractionSlotTagsMatchCondition
	public EGameplayInteractionMatchSlotTagSource Source;
	public EGameplayContainerMatchType MatchType;
	public bool bExactMatch;
	public bool bInvert;
}
