#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEditorSettings.h")]
public partial class UBlueprintEditorSettings : UDeveloperSettings {
// BlueprintEditorSettings
	public bool bDrawMidpointArrowsInBlueprints;
	public bool bShowGraphInstructionText;
	public bool bHideUnrelatedNodes;
	public bool bShowShortTooltips;
	public bool bEnableInputTriggerSupportWarnings;
	public bool bSplitContextTargetSettings;
	public bool bExposeAllMemberComponentFunctions;
	public bool bShowContextualFavorites;
	public bool bExposeDeprecatedFunctions;
	public bool bCompactCallOnMemberNodes;
	public bool bFlattenFavoritesMenus;
	public bool bAutoCastObjectConnections;
	public bool bShowViewportOnSimulate;
	public bool bSpawnDefaultBlueprintNodes;
	public bool bHideConstructionScriptComponentsInDetailsView;
	public bool bHostFindInBlueprintsInGlobalTab;
	public bool bNavigateToNativeFunctionsFromCallNodes;
	public bool bDoubleClickNavigatesToParent;
	public bool bEnableTypePromotion;
	public TSet<string> TypePromotionPinDenyList;
	public TArray<FAdditionalBlueprintCategory> AdditionalBlueprintCategories;
	public EBlueprintBreakpointReloadMethod BreakpointReloadMethod;
	public bool bEnablePinValueInspectionTooltips;
	public bool bEnableNamespaceEditorFeatures;
	public TArray<string> NamespacesToAlwaysInclude;
	public bool bEnableContextMenuTimeSlicing;
	public bool bFavorPureCastNodes;
	public byte SaveOnCompile;
	public bool bJumpToNodeErrors;
	public bool bAllowExplicitImpureNodeDisabling;
	public bool bShowActionMenuItemSignatures;
	public bool bBlueprintNodeUniqueNames;
	public bool bShowDetailedCompileResults;
	public int CompileEventDisplayThresholdMs;
	public float NodeTemplateCacheCapMB;
	public bool bShowInheritedVariables;
	public bool bAlwaysShowInterfacesInOverrides;
	public bool bShowParentClassInOverrides;
	public bool bShowEmptySections;
	public bool bShowAccessSpecifier;
	public TMap<FGuid,FEditedDocumentInfo> Bookmarks;
	public TArray<FBPEditorBookmarkNode> BookmarkNodes;
	public TMap<string,FPerBlueprintSettings> PerBlueprintSettings;
	public bool bIncludeCommentNodesInBookmarksTab;
	public bool bShowBookmarksForCurrentDocumentOnlyInTab;
	public TMap<int,FEditedDocumentInfo> GraphEditorQuickJumps;
	public bool bEnableNamespaceFilteringFeatures;
	public bool bEnableNamespaceImportingFeatures;
	public bool bInheritImportedNamespacesFromParentBP;
	public TArray<TSoftObjectPtr<UClass>> BaseClassesToAllowRecompilingDuringPlayInEditor;
}
