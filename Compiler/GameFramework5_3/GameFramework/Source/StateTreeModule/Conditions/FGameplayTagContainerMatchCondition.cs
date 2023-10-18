namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>HasAnyTags / HasAllTags condition</summary>
[CppInclude("Conditions/StateTreeGameplayTagConditions.h")]
public partial struct FGameplayTagContainerMatchCondition {
	public EGameplayContainerMatchType MatchType;
	public bool bExactMatch;
	public bool bInvert;
}
