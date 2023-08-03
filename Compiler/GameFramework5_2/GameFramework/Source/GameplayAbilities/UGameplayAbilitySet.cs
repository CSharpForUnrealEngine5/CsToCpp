#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is an example DataAsset that could be used for defining a set of abilities to give to an AbilitySystemComponent and bind to an input command.</summary>
[CppInclude("GameplayAbilitySet.h")]
public partial class UGameplayAbilitySet : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Abilities</summary>
	public TArray<FGameplayAbilityBindInfo> Abilities;
}
