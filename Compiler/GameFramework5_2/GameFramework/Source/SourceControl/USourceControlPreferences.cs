#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Source Control Integration</summary>
[CppInclude("SourceControlPreferences.h")]
public partial class USourceControlPreferences : UDeveloperSettings {
	///<summary>Adds validation tag to changelist description on submit.</summary>
	public bool bEnableValidationTag;
	///<summary>Deletes new files when reverted.</summary>
	public bool bShouldDeleteNewFilesOnRevert;
	///<summary>Enables Uncontrolled Changelists features. The editor must be restarted for the change to be fully taken into account.</summary>
	public bool bEnableUncontrolledChangelists;
	///<summary>List of lines to add to any collection on checkin</summary>
	public TArray<string> CollectionChangelistTags;
	///<summary>Map of collection names and additional text to apply to changelist descriptions when checking them in</summary>
	public TMap<string,string> SpecificCollectionChangelistTags;
}
