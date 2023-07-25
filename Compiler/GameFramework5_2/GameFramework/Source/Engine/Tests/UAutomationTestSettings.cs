#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/AutomationTestSettings.h")]
///<summary>Implements the Editor's user settings.</summary>
public partial class UAutomationTestSettings : UObject {
// AutomationTestSettings
	public TArray<string> EngineTestModules;
	public TArray<string> EditorTestModules;
	public FSoftObjectPath AutomationTestmap;
	public TArray<FEditorMapPerformanceTestDefinition> EditorPerformanceTestMaps;
	public TArray<string> AssetsToOpen;
	public TArray<string> MapsToPIETest;
	public bool bUseAllProjectMapsToPlayInPIE;
	public FBuildPromotionTestSettings BuildPromotionTest;
	public FMaterialEditorPromotionSettings MaterialEditorPromotionTest;
	public FParticleEditorPromotionSettings ParticleEditorPromotionTest;
	public FBlueprintEditorPromotionSettings BlueprintEditorPromotionTest;
	public TArray<string> TestLevelFolders;
	public TArray<FExternalToolDefinition> ExternalTools;
	public TArray<FEditorImportExportTestDefinition> ImportExportTestDefinitions;
	public TArray<FLaunchOnTestSettings> LaunchOnSettings;
	public FIntPoint DefaultScreenshotResolution;
	public float PIETestDuration;
	public float DefaultInteractiveFramerate;
	public float DefaultInteractiveFramerateWaitTime;
	public float DefaultInteractiveFramerateDuration;
}
