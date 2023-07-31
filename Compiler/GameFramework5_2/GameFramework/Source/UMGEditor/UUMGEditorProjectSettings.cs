#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the UMG Editor Project Settings</summary>
[CppInclude("UMGEditorProjectSettings.h")]
public partial class UUMGEditorProjectSettings : UDeveloperSettings {
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
	///<summary>Set true to hide UMG-graph related elements when the graph editor is hidden</summary>
	public bool bGraphEditorHidden;
	///<summary>Set true to hide widget animation related elements in the UMG editor</summary>
	public bool bHideWidgetAnimationEditor;
	///<summary>Set true to filter all categories and widgets out in the palette, selectively enabling them later via permission lists</summary>
	public bool bUseEditorConfigPaletteFiltering;
	///<summary>The list of parent classes to choose from for newly constructed widget blueprints.</summary>
	public TArray<TSoftObjectPtr<UClass>> FavoriteWidgetParentClasses;
	///<summary>DebugResolutions</summary>
	public TArray<FDebugResolution> DebugResolutions;
	///<summary>Version</summary>
	public int Version;
}
