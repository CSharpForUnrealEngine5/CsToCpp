#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Structure that is used to combine tags from parent and child blueprints in a safe way</summary>
public partial struct FInheritedTagContainer {
// InheritedTagContainer
	public FGameplayTagContainer CombinedTags;
	public FGameplayTagContainer Added;
	public FGameplayTagContainer Removed;
}
