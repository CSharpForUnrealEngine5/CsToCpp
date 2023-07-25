#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateProjectDefs.h")]
public partial class UTemplateProjectDefs : UObject {
// TemplateProjectDefs
	public TArray<FLocalizedTemplateString> LocalizedDisplayNames;
	public TArray<FLocalizedTemplateString> LocalizedDescriptions;
	public TArray<string> FoldersToIgnore;
	public TArray<string> FilesToIgnore;
	public TArray<FTemplateFolderRename> FolderRenames;
	public TArray<FTemplateReplacement> FilenameReplacements;
	public TArray<FTemplateReplacement> ReplacementsInFiles;
	public string SortKey;
	public TArray<string> Categories;
	public string ClassTypes;
	public string AssetTypes;
	public bool bAllowProjectCreation;
	public bool bIsEnterprise;
	public bool bIsBlank;
	public bool bThumbnailAsIcon;
	public TArray<ETemplateSetting> HiddenSettings;
	public TArray<string> PacksToInclude;
	public EFeaturePackDetailLevel EditDetailLevelPreference;
	public TArray<FFeaturePackLevelSet> SharedContentPacks;
	public string StarterContent;
}
