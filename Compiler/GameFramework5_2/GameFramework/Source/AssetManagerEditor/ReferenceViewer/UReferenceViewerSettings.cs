#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReferenceViewer/ReferenceViewerSettings.h")]
public partial class UReferenceViewerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to limit the search depth for Referencers &amp; Dependencies</summary>
	public bool bLimitSearchDepth;
	///<summary>Whether to display the Referencers</summary>
	public bool bIsShowReferencers;
	///<summary>How deep to search references</summary>
	public int MaxSearchReferencerDepth;
	///<summary>Whether to display the Dependencies</summary>
	public bool bIsShowDependencies;
	///<summary>How deep to search dependanies</summary>
	public int MaxSearchDependencyDepth;
	///<summary>Whether or not to limit how many siblings can appear</summary>
	public bool bLimitSearchBreadth;
	///<summary>The max number of siblings that can appear from a node</summary>
	public int MaxSearchBreadth;
	///<summary>Whether or not to filter from a collection</summary>
	public bool bEnableCollectionFilter;
	///<summary>Show/Hide Soft References</summary>
	public bool bIsShowSoftReferences;
	///<summary>Show/Hide Hard References</summary>
	public bool bIsShowHardReferences;
	///<summary>Show/Hide EditorOnly References</summary>
	public bool bIsShowEditorOnlyReferences;
	///<summary>Show/Hide Management Assets (i.e. PrimaryAssetIds)</summary>
	public bool bIsShowManagementReferences;
	///<summary>Show/Hide Searchable Names (i.e. Gameplay Tags)</summary>
	public bool bIsShowSearchableNames;
	///<summary>Show/Hide Native Packages</summary>
	public bool bIsShowCodePackages;
	///<summary>Whether to show duplicate asset references</summary>
	public bool bIsShowDuplicates;
	///<summary>Whether to filter the search results or just select them</summary>
	public bool bIsShowFilteredPackagesOnly;
	///<summary>Whether to show the nodes in a compact (no thumbnail) view</summary>
	public bool bIsCompactMode;
	///<summary>Whether to show the package&#39;s path as a comment</summary>
	public bool bIsShowPath;
	///<summary>This turns on/off any filtering done though the SFilterBar</summary>
	public bool bFiltersEnabled;
	///<summary>When true, the filters bar auto updates based on the node types, otherwise user filters will be used</summary>
	public bool bAutoUpdateFilters;
	///<summary>The list of filters the user has built up</summary>
	public TArray<FilterState> UserFilters;
	///<summary>Enable the Find Path tool</summary>
	public bool bFindPathEnabled;
}
