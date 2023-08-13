namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for storing a list of gameplay tags as an ini list. This is used for both the central list and additional lists</summary>
[CppInclude("GameplayTagsSettings.h")]
public partial class UGameplayTagsList : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Relative path to the ini file that is backing this list</summary>
	public string ConfigFileName;
	///<summary>List of tags saved to this file</summary>
	public TArray<FGameplayTagTableRow> GameplayTagList;
}
