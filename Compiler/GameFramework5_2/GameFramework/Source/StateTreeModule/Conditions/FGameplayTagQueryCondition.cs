#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gameplay Tag Query match condition.</summary>
[CppInclude("Conditions/StateTreeGameplayTagConditions.h")]
public partial struct FGameplayTagQueryCondition {
	public FGameplayTagQuery TagQuery;
	public bool bInvert;
}
