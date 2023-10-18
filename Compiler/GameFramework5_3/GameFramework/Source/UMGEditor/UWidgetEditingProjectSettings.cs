namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the UMG Editor Project Settings</summary>
[CppInclude("WidgetEditingProjectSettings.h")]
public partial class UWidgetEditingProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultCompilerOptions</summary>
	public FWidgetCompilerOptions DefaultCompilerOptions;
	///<summary>DirectoryCompilerOptions</summary>
	public TArray<FDirectoryWidgetCompilerOptions> DirectoryCompilerOptions;
	///<summary>bShowWidgetsFromEngineContent</summary>
	public bool bShowWidgetsFromEngineContent;
	///<summary>bShowWidgetsFromDeveloperContent</summary>
	public bool bShowWidgetsFromDeveloperContent;
	///<summary>CategoriesToHide</summary>
	public TArray<string> CategoriesToHide;
	///<summary>WidgetClassesToHide</summary>
	public TArray<FSoftClassPath> WidgetClassesToHide;
	///<summary>Enables a dialog that lets you select a root widget before creating a widget blueprint</summary>
	public bool bUseWidgetTemplateSelector;
	///<summary>This list populates the common class section of the root widget selection dialog</summary>
	public TArray<TSoftObjectPtr<UClass>> CommonRootWidgetClasses;
	///<summary>The panel widget to place at the root of all newly constructed widget blueprints. Can be empty.</summary>
	public UClass DefaultRootWidget;
	///<summary>Set true to enable the Is Variable checkbox in the UMG editor DetailView.</summary>
	public bool bEnableMakeVariable;
	///<summary>Set true to hide widget animation related elements in the UMG editor.</summary>
	public bool bEnableWidgetAnimationEditor;
	///<summary>Set true to enabled the Palette window in the UMG editor.</summary>
	public bool bEnablePaletteWindow;
	///<summary>Set true to enabled the LIbrary window in the UMG editor.</summary>
	public bool bEnableLibraryWindow;
	///<summary>Set true to enabled the Widget Hierarchy window in the UMG editor.</summary>
	public bool bEnableHierarchyWindow;
	///<summary>Set true to enabled the Bind Widget window in the UMG editor.</summary>
	public bool bEnableBindWidgetWindow;
	///<summary>Set true to enabled the Navigation Simulation window in the UMG editor.</summary>
	public bool bEnableNavigationSimulationWindow;
	///<summary>Set true to filter all categories and widgets out in the palette, selectively enabling them later via permission lists.</summary>
	public bool bUseEditorConfigPaletteFiltering;
	///<summary>Enables a dialog that lets you select the parent class in a tree view.</summary>
	public bool bUseUserWidgetParentClassViewerSelector;
	///<summary>Enables a dialog that lets you select the parent class in a default view.</summary>
	public bool bUseUserWidgetParentDefaultClassViewerSelector;
	///<summary>The list of parent classes to choose from for newly constructed widget blueprints.</summary>
	public TArray<TSoftObjectPtr<UClass>> FavoriteWidgetParentClasses;
	///<summary>DebugResolutions</summary>
	public TArray<FDebugResolution> DebugResolutions;
	///<summary>Version</summary>
	public int Version;
}
