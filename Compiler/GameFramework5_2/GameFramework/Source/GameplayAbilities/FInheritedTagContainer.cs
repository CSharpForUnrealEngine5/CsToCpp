namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that is used to combine tags from parent and child blueprints in a safe way</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FInheritedTagContainer {
	public FGameplayTagContainer CombinedTags;
	public FGameplayTagContainer Added;
	public FGameplayTagContainer Removed;
}
