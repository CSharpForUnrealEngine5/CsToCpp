#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsSettings.h")]
///<summary>Category remapping. This allows base engine tag category meta data to remap to multiple project-specific categories.</summary>
public partial struct FGameplayTagCategoryRemap {
// GameplayTagCategoryRemap
	public string BaseCategory;
	public TArray<string> RemapCategories;
}
