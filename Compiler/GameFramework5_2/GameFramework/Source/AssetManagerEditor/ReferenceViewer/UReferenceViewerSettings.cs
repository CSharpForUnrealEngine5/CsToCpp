#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReferenceViewer/ReferenceViewerSettings.h")]
public partial class UReferenceViewerSettings : UObject {
// ReferenceViewerSettings
	public bool bLimitSearchDepth;
	public bool bIsShowReferencers;
	public int MaxSearchReferencerDepth;
	public bool bIsShowDependencies;
	public int MaxSearchDependencyDepth;
	public bool bLimitSearchBreadth;
	public int MaxSearchBreadth;
	public bool bEnableCollectionFilter;
	public bool bIsShowSoftReferences;
	public bool bIsShowHardReferences;
	public bool bIsShowEditorOnlyReferences;
	public bool bIsShowManagementReferences;
	public bool bIsShowSearchableNames;
	public bool bIsShowCodePackages;
	public bool bIsShowDuplicates;
	public bool bIsShowFilteredPackagesOnly;
	public bool bIsCompactMode;
	public bool bIsShowPath;
	public bool bFiltersEnabled;
	public bool bAutoUpdateFilters;
	public TArray<FilterState> UserFilters;
	public bool bFindPathEnabled;
}
