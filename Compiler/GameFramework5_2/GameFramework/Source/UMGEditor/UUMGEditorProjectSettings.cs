#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UMGEditorProjectSettings.h")]
///<summary>Implements the settings for the UMG Editor Project Settings</summary>
public partial class UUMGEditorProjectSettings : UDeveloperSettings {
// UMGEditorProjectSettings
	public FWidgetCompilerOptions DefaultCompilerOptions;
	public TArray<FDirectoryWidgetCompilerOptions> DirectoryCompilerOptions;
	public bool bShowWidgetsFromEngineContent;
	public bool bShowWidgetsFromDeveloperContent;
	public TArray<string> CategoriesToHide;
	public TArray<FSoftClassPath> WidgetClassesToHide;
	public bool bUseWidgetTemplateSelector;
	public TArray<TSoftObjectPtr<UClass>> CommonRootWidgetClasses;
	public UClass DefaultRootWidget;
	public bool bGraphEditorHidden;
	public bool bHideWidgetAnimationEditor;
	public bool bUseEditorConfigPaletteFiltering;
	public TArray<TSoftObjectPtr<UClass>> FavoriteWidgetParentClasses;
	public TArray<FDebugResolution> DebugResolutions;
	public int Version;
}
