#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsSettings.h")]
///<summary>Base class for storing a list of restricted gameplay tags as an ini list. This is used for both the central list and additional lists</summary>
public partial class URestrictedGameplayTagsList : UObject {
// RestrictedGameplayTagsList
	public string ConfigFileName;
	public TArray<FRestrictedGameplayTagTableRow> RestrictedGameplayTagList;
}
