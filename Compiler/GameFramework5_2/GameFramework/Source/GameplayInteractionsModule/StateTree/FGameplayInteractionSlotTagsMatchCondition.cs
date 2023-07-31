#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Condition to check if Gameplay Tags on a Smart Object slot match the specified tags.</summary>
[CppInclude("StateTree/GameplayInteractionConditions.h")]
public partial struct FGameplayInteractionSlotTagsMatchCondition {
	public EGameplayInteractionMatchSlotTagSource Source;
	public EGameplayContainerMatchType MatchType;
	public bool bExactMatch;
	public bool bInvert;
}
