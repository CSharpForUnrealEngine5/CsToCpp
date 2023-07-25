#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceControlPreferences.h")]
///<summary>Settings for the Source Control Integration</summary>
public partial class USourceControlPreferences : UDeveloperSettings {
// SourceControlPreferences
	public bool bEnableValidationTag;
	public bool bShouldDeleteNewFilesOnRevert;
	public bool bEnableUncontrolledChangelists;
	public TArray<string> CollectionChangelistTags;
	public TMap<string,string> SpecificCollectionChangelistTags;
}
