#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ContentBrowserSettings.h")]
///<summary>Implements content browser settings.  These are global not per-project</summary>
public partial class UContentBrowserSettings : UObject {
// ContentBrowserSettings
	public int NumObjectsToLoadBeforeWarning;
	public bool bOpenSourcesPanelByDefault;
	public bool RealTimeThumbnails;
	public bool DisplayFolders;
	public bool DisplayEmptyFolders;
	public bool FilterRecursively;
	public bool bShowAllFolder;
	public bool bOrganizeFolders;
	public bool bDisplayContentFolderSuffix;
	public bool bDisplayFriendlyNameForPluginFolders;
	public int NumObjectsInRecentList;
	public bool bEnableRealtimeMaterialInstanceThumbnails;
	public bool DisplayEngineFolder;
	public bool DisplayDevelopersFolder;
	public bool DisplayL10NFolder;
	public bool DisplayPluginFolders;
	public bool DisplayFavorites;
	public bool DockCollections;
	public bool DisplayCppFolders;
	public bool IncludeClassNames;
	public bool IncludeAssetPaths;
	public bool IncludeCollectionNames;
}
