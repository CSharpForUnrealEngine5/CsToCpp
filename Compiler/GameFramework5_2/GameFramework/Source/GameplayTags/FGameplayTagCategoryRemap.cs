namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Category remapping. This allows base engine tag category meta data to remap to multiple project-specific categories.</summary>
[CppInclude("GameplayTagsSettings.h")]
public partial struct FGameplayTagCategoryRemap {
	public string BaseCategory;
	public TArray<string> RemapCategories;
}
