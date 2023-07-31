#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Every set condition within this query must match in order for the query to match. i.e. individual query elements are ANDed together.</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectQuery {
	public FActiveGameplayEffectQueryCustomMatch_Dynamic CustomMatchDelegate_BP;
	public FGameplayTagQuery OwningTagQuery;
	public FGameplayTagQuery EffectTagQuery;
	public FGameplayTagQuery SourceTagQuery;
	public FGameplayAttribute ModifyingAttribute;
	public UObject EffectSource;
	public UClass EffectDefinition;
}
