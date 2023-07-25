#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayAbilitySet.h")]
///<summary>This is an example DataAsset that could be used for defining a set of abilities to give to an AbilitySystemComponent and bind to an input command.</summary>
public partial class UGameplayAbilitySet : UDataAsset {
// GameplayAbilitySet
	public TArray<FGameplayAbilityBindInfo> Abilities;
}
