#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example struct that pairs a enum input command to a GameplayAbilityClass.6</summary>
[CppInclude("GameplayAbilitySet.h")]
public partial struct FGameplayAbilityBindInfo {
	public EGameplayAbilityInputBinds Command;
	public UClass GameplayAbilityClass;
}
