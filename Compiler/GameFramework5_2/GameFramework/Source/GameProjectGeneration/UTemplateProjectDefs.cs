#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateProjectDefs.h")]
public partial class UTemplateProjectDefs : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LocalizedDisplayNames</summary>
	public TArray<FLocalizedTemplateString> LocalizedDisplayNames;
	///<summary>LocalizedDescriptions</summary>
	public TArray<FLocalizedTemplateString> LocalizedDescriptions;
	///<summary>FoldersToIgnore</summary>
	public TArray<string> FoldersToIgnore;
	///<summary>FilesToIgnore</summary>
	public TArray<string> FilesToIgnore;
	///<summary>FolderRenames</summary>
	public TArray<FTemplateFolderRename> FolderRenames;
	///<summary>FilenameReplacements</summary>
	public TArray<FTemplateReplacement> FilenameReplacements;
	///<summary>ReplacementsInFiles</summary>
	public TArray<FTemplateReplacement> ReplacementsInFiles;
	///<summary>SortKey</summary>
	public string SortKey;
	///<summary>Categories</summary>
	public TArray<string> Categories;
	///<summary>ClassTypes</summary>
	public string ClassTypes;
	///<summary>AssetTypes</summary>
	public string AssetTypes;
	///<summary>Should we allow creation of a project from this template. If this is false, the template is treated as a feature pack.</summary>
	public bool bAllowProjectCreation;
	///<summary>Is this an enterprise template?</summary>
	public bool bIsEnterprise;
	///<summary>Is this a blank template? Determines whether we can override the default map when creating the project.</summary>
	public bool bIsBlank;
	///<summary>Is there a rendered thumbnail that should be treated as the project template icon. If this is true the thumbnail takes up the full tile size rather than a 64x64 icon</summary>
	public bool bThumbnailAsIcon;
	///<summary>Optional list of settings to hide. If none are specified, then all settings are shown.</summary>
	public TArray<ETemplateSetting> HiddenSettings;
	///<summary>Optional list of feature packs to include</summary>
	public TArray<string> PacksToInclude;
	///<summary>What detail level to edit when editing shared template resources</summary>
	public EFeaturePackDetailLevel EditDetailLevelPreference;
	///<summary>Shared feature packs. The files in these packs listed in these structures marked as &#39;additionalfiles&#39; will be copied on project generation</summary>
	public TArray<FFeaturePackLevelSet> SharedContentPacks;
	///<summary>StarterContent</summary>
	public string StarterContent;
}
