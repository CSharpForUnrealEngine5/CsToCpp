#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEditorSettings.h")]
public partial class UBlueprintEditorSettings : UDeveloperSettings {
	///<summary>Should arrows indicating data/execution flow be drawn halfway along wires?</summary>
	public bool bDrawMidpointArrowsInBlueprints;
	///<summary>Determines if lightweight tutorial text shows up at the top of empty blueprint graphs</summary>
	public bool bShowGraphInstructionText;
	///<summary>If true, fade nodes which are not connected to the selected nodes</summary>
	public bool bHideUnrelatedNodes;
	///<summary>If true, use short tooltips whenever possible</summary>
	public bool bShowShortTooltips;
	///<summary>If enabled Input Action nodes will hide unsupported trigger pins and give warnings when using unsupported triggers.</summary>
	public bool bEnableInputTriggerSupportWarnings;
	///<summary>If enabled, we&#39;ll save off your chosen target setting based off of the context (allowing you to have different preferences based off what you&#39;re operating on).</summary>
	public bool bSplitContextTargetSettings;
	///<summary>If enabled, then ALL component functions are exposed to the context menu (when the contextual target is a component owner). Ignores &quot;ExposeFunctionCategories&quot; metadata for components.</summary>
	public bool bExposeAllMemberComponentFunctions;
	///<summary>If enabled, then a separate section with your Blueprint favorites will be pined to the top of the context menu.</summary>
	public bool bShowContextualFavorites;
	///<summary>If enabled, deprecated functions will be visible in the context menu and will be available for override implementation. By default, functions marked as deprecated are not exposed in either case.</summary>
	public bool bExposeDeprecatedFunctions;
	///<summary>If enabled, then call-on-member actions will be spawned as a single node (instead of a GetMember + FunctionCall node).</summary>
	public bool bCompactCallOnMemberNodes;
	///<summary>If enabled, then your Blueprint favorites will be uncategorized, leaving you with less nested categories to sort through.</summary>
	public bool bFlattenFavoritesMenus;
	///<summary>If enabled, then you&#39;ll be able to directly connect arbitrary object pins together (a pure cast node will be injected automatically).</summary>
	public bool bAutoCastObjectConnections;
	///<summary>If true will show the viewport tab when simulate is clicked.</summary>
	public bool bShowViewportOnSimulate;
	///<summary>If set will spawn default &quot;ghost&quot; event nodes in new Blueprints, modifiable in the [DefaultEventNodes] section of EditorPerProjectUserSettings</summary>
	public bool bSpawnDefaultBlueprintNodes;
	///<summary>If set will exclude components added in a Blueprint class Construction Script from the component details view</summary>
	public bool bHideConstructionScriptComponentsInDetailsView;
	///<summary>bHostFindInBlueprintsInGlobalTab</summary>
	public bool bHostFindInBlueprintsInGlobalTab;
	///<summary>If set, double clicking on a call function node will attempt to navigate an open C++ editor to the native source definition</summary>
	public bool bNavigateToNativeFunctionsFromCallNodes;
	///<summary>Double click to navigate up to the parent graph</summary>
	public bool bDoubleClickNavigatesToParent;
	///<summary>Allows for pin types to be promoted to others, i.e. float to double</summary>
	public bool bEnableTypePromotion;
	///<summary>If a pin type is within this list, then it will never be marked as a possible promotable function.</summary>
	public TSet<string> TypePromotionPinDenyList;
	///<summary>List of additional category names to show in Blueprints, optionally filtered by parent class type.</summary>
	public TArray<FAdditionalBlueprintCategory> AdditionalBlueprintCategories;
	///<summary>How to handle previously-set breakpoints on reload.</summary>
	public EBlueprintBreakpointReloadMethod BreakpointReloadMethod;
	///<summary>If enabled, pin tooltips during PIE will be interactive</summary>
	public bool bEnablePinValueInspectionTooltips;
	///<summary>Whether to enable namespace importing and filtering features in the Blueprint editor</summary>
	public bool bEnableNamespaceEditorFeatures;
	///<summary>A list of namespace identifiers that the Blueprint editor should always import by default. Requires Blueprint namespace features to be enabled and only applies to the current local user. Editing this list will also cause any visible Blueprint editor windows to be closed.</summary>
	public TArray<string> NamespacesToAlwaysInclude;
	///<summary>If enabled, when the Blueprint graph context menu is invoked (e.g. by dragging off a pin), it will not block the UI while it populates the available actions list.</summary>
	public bool bEnableContextMenuTimeSlicing;
	///<summary>If enabled, then placed cast nodes will default to their &quot;pure&quot; form (meaning: without execution pins).</summary>
	public bool bFavorPureCastNodes;
	///<summary>Determines when to save Blueprints post-compile</summary>
	public ESaveOnCompile SaveOnCompile;
	///<summary>When enabled, if a blueprint has compiler errors, then the graph will jump and focus on the first node generating an error</summary>
	public bool bJumpToNodeErrors;
	///<summary>If enabled, nodes can be explicitly disabled via context menu when right-clicking on impure nodes in the Blueprint editor. Disabled nodes will not be compiled, but also will not break existing connections.</summary>
	public bool bAllowExplicitImpureNodeDisabling;
	///<summary>If enabled, tooltips on action menu items will show the associated action&#39;s signature id (can be used to setup custom favorites menus).</summary>
	public bool bShowActionMenuItemSignatures;
	///<summary>If enabled, blueprint nodes in the event graph will display with unique names rather than their display name.</summary>
	public bool bBlueprintNodeUniqueNames;
	///<summary>If enabled, additional details will be displayed in the Compiler Results tab after compiling a blueprint.</summary>
	public bool bShowDetailedCompileResults;
	///<summary>Minimum event time threshold used as a filter when additional details are enabled for display in the Compiler Results tab. A value of zero means that all events will be included in the final summary.</summary>
	public int CompileEventDisplayThresholdMs;
	///<summary>The node template cache is used to speed up blueprint menuing. This determines the peak data size for that cache.</summary>
	public float NodeTemplateCacheCapMB;
	///<summary>If set we&#39;ll show the inherited variables in the My Blueprint view.</summary>
	public bool bShowInheritedVariables;
	///<summary>If set interface functions will always show in the overrides menu, even if they are already shown in the interfaces menu</summary>
	public bool bAlwaysShowInterfacesInOverrides;
	///<summary>If set then the parent class will be listed next to the override function name in the overrides function menu</summary>
	public bool bShowParentClassInOverrides;
	///<summary>If set we&#39;ll show empty sections in the My Blueprint view.</summary>
	public bool bShowEmptySections;
	///<summary>If set we&#39;ll show the access specifier of functions in the My Blueprint view</summary>
	public bool bShowAccessSpecifier;
	///<summary>Blueprint bookmark database</summary>
	public TMap<FGuid,FEditedDocumentInfo> Bookmarks;
	///<summary>Blueprint bookmark nodes (for display)</summary>
	public TArray<FBPEditorBookmarkNode> BookmarkNodes;
	///<summary>Maps Blueprint path to settings such as breakpoints</summary>
	public TMap<string,FPerBlueprintSettings> PerBlueprintSettings;
	///<summary>If enabled, comment nodes will be included in the tree view display in the Bookmarks tab.</summary>
	public bool bIncludeCommentNodesInBookmarksTab;
	///<summary>If enabled, only the bookmarks for the current document will be shown in the Bookmarks tab.</summary>
	public bool bShowBookmarksForCurrentDocumentOnlyInTab;
	///<summary>Blueprint graph editor &quot;Quick Jump&quot; command bindings</summary>
	public TMap<int,FEditedDocumentInfo> GraphEditorQuickJumps;
	///<summary>Whether to enable namespace filtering features in the Blueprint editor // @todo_namespaces - Remove this if/when dependent code is changed to utilize the single setting above.</summary>
	public bool bEnableNamespaceFilteringFeatures;
	///<summary>Whether to enable namespace importing features in the Blueprint editor // @todo_namespaces - Remove this if/when dependent code is changed to utilize the single setting above.</summary>
	public bool bEnableNamespaceImportingFeatures;
	///<summary>Whether to inherit the set of imported namespaces from the parent class hierarchy // @todo_namespaces - Remove this if/when this becomes a permanent setting. For now this is experimental.</summary>
	public bool bInheritImportedNamespacesFromParentBP;
	///<summary>Any blueprint deriving from one of these base classes will be allowed to recompile during Play-in-Editor</summary>
	public TArray<TSoftObjectPtr<UClass>> BaseClassesToAllowRecompilingDuringPlayInEditor;
}
