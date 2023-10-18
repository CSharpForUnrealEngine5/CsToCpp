namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagAssetInterface.h")]
public partial class UGameplayTagAssetInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Get any owned gameplay tags on the asset</summary>
	public virtual void GetOwnedGameplayTags(FGameplayTagContainer TagContainer) {}
	///<summary>Check if the asset has a gameplay tag that matches against the specified tag (expands to include parents of asset tags)</summary>
	public virtual bool HasMatchingGameplayTag(FGameplayTag TagToCheck) { return default; }
	///<summary>Check if the asset has gameplay tags that matches against all of the specified tags (expands to include parents of asset tags)</summary>
	public virtual bool HasAllMatchingGameplayTags(FGameplayTagContainer TagContainer) { return default; }
	///<summary>Check if the asset has gameplay tags that matches against any of the specified tags (expands to include parents of asset tags)</summary>
	public virtual bool HasAnyMatchingGameplayTags(FGameplayTagContainer TagContainer) { return default; }
}
