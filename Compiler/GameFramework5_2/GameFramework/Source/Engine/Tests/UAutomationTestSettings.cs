#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Editor&#39;s user settings.</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial class UAutomationTestSettings : UObject {
	///<summary>Modules to load that have engine tests</summary>
	public TArray<string> EngineTestModules;
	///<summary>Modules to load that have editor tests</summary>
	public TArray<string> EditorTestModules;
	///<summary>The automation test map to be used for several of the automation tests.</summary>
	public FSoftObjectPath AutomationTestmap;
	///<summary>The map to be used for the editor performance capture tool.</summary>
	public TArray<FEditorMapPerformanceTestDefinition> EditorPerformanceTestMaps;
	///<summary>Asset to test for open in automation process</summary>
	public TArray<string> AssetsToOpen;
	///<summary>Maps to PIE during the PIE test</summary>
	public TArray<string> MapsToPIETest;
	///<summary>Use all Maps from project for PlayMapInPIE test</summary>
	public bool bUseAllProjectMapsToPlayInPIE;
	///<summary>Editor build promotion test settings</summary>
	public FBuildPromotionTestSettings BuildPromotionTest;
	///<summary>Material editor promotion test settings</summary>
	public FMaterialEditorPromotionSettings MaterialEditorPromotionTest;
	///<summary>Particle editor promotion test settings</summary>
	public FParticleEditorPromotionSettings ParticleEditorPromotionTest;
	///<summary>Blueprint editor promotion test settings</summary>
	public FBlueprintEditorPromotionSettings BlueprintEditorPromotionTest;
	///<summary>Folders containing levels to exclude from automated tests</summary>
	public TArray<string> TestLevelFolders;
	///<summary>External executables and scripts to run as part of automation.</summary>
	public TArray<FExternalToolDefinition> ExternalTools;
	///<summary>Asset import / Export test settings</summary>
	public TArray<FEditorImportExportTestDefinition> ImportExportTestDefinitions;
	///<summary>The map and device type to be used for the editor Launch On With Map Iterations test.</summary>
	public TArray<FLaunchOnTestSettings> LaunchOnSettings;
	///<summary>The default resolution to take all automation screenshots at.</summary>
	public FIntPoint DefaultScreenshotResolution;
	///<summary>PIE test duration in seconds. Only applied if you do PIETest</summary>
	public float PIETestDuration;
	///<summary>Default value used for FWaitForInteractiveFrameRate. This is a framerate determine to be suitably &quot;interactive&quot;, but may be</summary>
	public float DefaultInteractiveFramerate;
	///<summary>Default wait time in seconds for FWaitForInteractiveFrameRate. After this time a test will fail.</summary>
	public float DefaultInteractiveFramerateWaitTime;
	///<summary>Default time in seconds that DefaultInteractiveFramerate must remain true in FWaitForInteractiveFrameRate</summary>
	public float DefaultInteractiveFramerateDuration;
}
