namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements content browser settings.  These are global not per-project</summary>
[CppInclude("Settings/ContentBrowserSettings.h")]
public partial class UContentBrowserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The number of objects to load at once in the Content Browser before displaying a warning about loading many assets</summary>
	public int NumObjectsToLoadBeforeWarning;
	///<summary>Whether the Content Browser should open the Sources Panel by default</summary>
	public bool bOpenSourcesPanelByDefault;
	///<summary>Whether to render thumbnails for loaded assets in real-time in the Content Browser</summary>
	public bool RealTimeThumbnails;
	///<summary>Whether to display folders in the asset view of the content browser. Note that this implies &#39;Show Only Assets in Selected Folders&#39;.</summary>
	public bool DisplayFolders;
	///<summary>Whether to empty display folders in the asset view of the content browser.</summary>
	public bool DisplayEmptyFolders;
	///<summary>Whether to filter recursively when a filter is applied in the asset view of the content browser.</summary>
	public bool FilterRecursively;
	///<summary>Whether to group root folders under a common folder in the path view</summary>
	public bool bShowAllFolder;
	///<summary>Whether to organize folders in the content browser</summary>
	public bool bOrganizeFolders;
	///<summary>Whether to append &#39;Content&#39; text to displayed folder names</summary>
	public bool bDisplayContentFolderSuffix;
	///<summary>Whether display friendly name as plugin folder names</summary>
	public bool bDisplayFriendlyNameForPluginFolders;
	///<summary>The number of objects to keep in the Content Browser Recently Opened filter</summary>
	public int NumObjectsInRecentList;
	///<summary>Enables the rendering of Material Instance thumbnail previews</summary>
	public bool bEnableRealtimeMaterialInstanceThumbnails;
	///<summary>Whether to display the engine folder in the assets view of the content browser.</summary>
	public bool DisplayEngineFolder;
	///<summary>Whether to display the developers folder in the path view of the content browser</summary>
	public bool DisplayDevelopersFolder;
	///<summary>DisplayL10NFolder</summary>
	public bool DisplayL10NFolder;
	///<summary>List of plugin folders to display in the content browser.</summary>
	public bool DisplayPluginFolders;
	///<summary>DisplayFavorites</summary>
	public bool DisplayFavorites;
	///<summary>DockCollections</summary>
	public bool DockCollections;
	///<summary>DisplayCppFolders</summary>
	public bool DisplayCppFolders;
	///<summary>IncludeClassNames</summary>
	public bool IncludeClassNames;
	///<summary>IncludeAssetPaths</summary>
	public bool IncludeAssetPaths;
	///<summary>IncludeCollectionNames</summary>
	public bool IncludeCollectionNames;
}
