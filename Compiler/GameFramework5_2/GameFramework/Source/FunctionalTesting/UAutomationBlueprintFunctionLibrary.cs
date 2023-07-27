#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationBlueprintFunctionLibrary.h")]
public partial class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// AutomationBlueprintFunctionLibrary
	public static void FinishLoadingBeforeScreenshot() {}
	public static void TakeAutomationScreenshot(UObject WorldContextObject,FLatentActionInfo LatentInfo,string Name,string Notes,FAutomationScreenshotOptions Options) {}
	public static void TakeAutomationScreenshotAtCamera(UObject WorldContextObject,FLatentActionInfo LatentInfo,ACameraActor Camera,string NameOverride,string Notes,FAutomationScreenshotOptions Options) {}
	public static void TakeAutomationScreenshotOfUI(UObject WorldContextObject,FLatentActionInfo LatentInfo,string Name,FAutomationScreenshotOptions Options) {}
	public static void EnableStatGroup(UObject WorldContextObject,string GroupName) {}
	public static void DisableStatGroup(UObject WorldContextObject,string GroupName) {}
	public static float GetStatIncAverage(string StatName) { return default; }
	public static float GetStatIncMax(string StatName) { return default; }
	public static float GetStatExcAverage(string StatName) { return default; }
	public static float GetStatExcMax(string StatName) { return default; }
	public static float GetStatCallCount(string StatName) { return default; }
	public static bool AreAutomatedTestsRunning() { return default; }
	public static void AutomationWaitForLoading(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAutomationWaitForLoadingOptions Options) {}
	public static UAutomationEditorTask TakeHighResScreenshot(int ResX,int ResY,string Filename,ACameraActor Camera/*=nullptr*/,bool bMaskEnabled/*=false*/,bool bCaptureHDR/*=false*/,EComparisonTolerance ComparisonTolerance/*=EComparisonTolerance.Low*/,string ComparisonNotes/*=TEXT("")*/,float Delay/*=0.0f*/) { return default; }
	public static bool CompareImageAgainstReference(string ImageFilePath,string ComparisonName/*=TEXT("")*/,EComparisonTolerance ComparisonTolerance/*=EComparisonTolerance.Low*/,string ComparisonNotes/*=TEXT("")*/,UObject WorldContextObject/*=nullptr*/) { return default; }
	public static void AddTestTelemetryData(string DataPoint,float Measurement,string Context/*=TEXT("")*/) {}
	public static void SetTestTelemetryStorage(string StorageName) {}
	public static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForGameplay(EComparisonTolerance Tolerance/*=EComparisonTolerance.Low*/,float Delay/*=0.2f*/) { return default; }
	public static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForRendering(EComparisonTolerance Tolerance/*=EComparisonTolerance.Low*/,float Delay/*=0.2f*/) { return default; }
	public static void AddExpectedLogError(string ExpectedPatternString,int Occurrences/*=1*/,bool ExactMatch/*=false*/) {}
	public static void SetScalabilityQualityLevelRelativeToMax(UObject WorldContextObject,int Value/*=1*/) {}
	public static void SetScalabilityQualityToEpic(UObject WorldContextObject) {}
	public static void SetScalabilityQualityToLow(UObject WorldContextObject) {}
	public static void SetEditorViewportViewMode(EViewModeIndex Index) {}
	public static void SetEditorViewportVisualizeBuffer(string BufferName) {}
}
