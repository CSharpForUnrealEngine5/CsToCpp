namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationBlueprintFunctionLibrary.h")]
public partial class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>FinishLoadingBeforeScreenshot</summary>
	public static void FinishLoadingBeforeScreenshot() {}
	///<summary>Takes a screenshot of the game&#39;s viewport.  Does not capture any UI.</summary>
	public static void TakeAutomationScreenshot(UObject WorldContextObject,FLatentActionInfo LatentInfo,string Name,string Notes,FAutomationScreenshotOptions Options) {}
	///<summary>Takes a screenshot of the game&#39;s viewport, from a particular camera actors POV.  Does not capture any UI.</summary>
	public static void TakeAutomationScreenshotAtCamera(UObject WorldContextObject,FLatentActionInfo LatentInfo,ACameraActor Camera,string NameOverride,string Notes,FAutomationScreenshotOptions Options) {}
	///<summary>TakeAutomationScreenshotOfUI</summary>
	public static void TakeAutomationScreenshotOfUI(UObject WorldContextObject,FLatentActionInfo LatentInfo,string Name,FAutomationScreenshotOptions Options) {}
	///<summary>EnableStatGroup</summary>
	public static void EnableStatGroup(UObject WorldContextObject,string GroupName) {}
	///<summary>DisableStatGroup</summary>
	public static void DisableStatGroup(UObject WorldContextObject,string GroupName) {}
	///<summary>GetStatIncAverage</summary>
	public static float GetStatIncAverage(string StatName) { return default; }
	///<summary>GetStatIncMax</summary>
	public static float GetStatIncMax(string StatName) { return default; }
	///<summary>GetStatExcAverage</summary>
	public static float GetStatExcAverage(string StatName) { return default; }
	///<summary>GetStatExcMax</summary>
	public static float GetStatExcMax(string StatName) { return default; }
	///<summary>GetStatCallCount</summary>
	public static float GetStatCallCount(string StatName) { return default; }
	///<summary>Lets you know if any automated tests are running, or are about to run and the automation system is spinning up tests.</summary>
	public static bool AreAutomatedTestsRunning() { return default; }
	///<summary>AutomationWaitForLoading</summary>
	public static void AutomationWaitForLoading(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAutomationWaitForLoadingOptions Options) {}
	///<summary>take high res screenshot in editor.</summary>
	public static UAutomationEditorTask TakeHighResScreenshot(int ResX,int ResY,string Filename,ACameraActor Camera/*=nullptr*/,bool bMaskEnabled/*=false*/,bool bCaptureHDR/*=false*/,EComparisonTolerance ComparisonTolerance/*=EComparisonTolerance.Low*/,string ComparisonNotes/*=TEXT("")*/,float Delay/*=0.0f*/) { return default; }
	///<summary>request image comparison.</summary>
	public static bool CompareImageAgainstReference(string ImageFilePath,string ComparisonName/*=TEXT("")*/,EComparisonTolerance ComparisonTolerance/*=EComparisonTolerance.Low*/,string ComparisonNotes/*=TEXT("")*/,UObject WorldContextObject/*=nullptr*/) { return default; }
	///<summary>Add Telemetry data to currently running automated test.</summary>
	public static void AddTestTelemetryData(string DataPoint,float Measurement,string Context/*=TEXT("")*/) {}
	///<summary>Set Telemetry data storage name of currently running automated test.</summary>
	public static void SetTestTelemetryStorage(string StorageName) {}
	///<summary>GetDefaultScreenshotOptionsForGameplay</summary>
	public static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForGameplay(EComparisonTolerance Tolerance/*=EComparisonTolerance.Low*/,float Delay/*=0.2f*/) { return default; }
	///<summary>GetDefaultScreenshotOptionsForRendering</summary>
	public static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForRendering(EComparisonTolerance Tolerance/*=EComparisonTolerance.Low*/,float Delay/*=0.2f*/) { return default; }
	///<summary>Mute the report of log error and warning matching a pattern during an automated test</summary>
	public static void AddExpectedLogError(string ExpectedPatternString,int Occurrences/*=1*/,bool ExactMatch/*=false*/) {}
	///<summary>Sets all other settings based on an overall value</summary>
	public static void SetScalabilityQualityLevelRelativeToMax(UObject WorldContextObject,int Value/*=1*/) {}
	///<summary>SetScalabilityQualityToEpic</summary>
	public static void SetScalabilityQualityToEpic(UObject WorldContextObject) {}
	///<summary>SetScalabilityQualityToLow</summary>
	public static void SetScalabilityQualityToLow(UObject WorldContextObject) {}
	///<summary>Sets all viewports of the first found level editor to have the given ViewMode (Lit/Unlit/etc.) *</summary>
	public static void SetEditorViewportViewMode(EViewModeIndex Index) {}
	///<summary>Sets all viewports of the first found level editor to have the VisualizeBuffer ViewMode and also display a given buffer (BaseColor/Metallic/Roughness/etc.) *</summary>
	public static void SetEditorViewportVisualizeBuffer(string BufferName) {}
}
