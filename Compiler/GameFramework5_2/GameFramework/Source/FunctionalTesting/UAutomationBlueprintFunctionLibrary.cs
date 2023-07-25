#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationBlueprintFunctionLibrary.h")]
public partial class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// AutomationBlueprintFunctionLibrary
	public void FinishLoadingBeforeScreenshot() {}
	public void TakeAutomationScreenshot(UObject WorldContextObject,FLatentActionInfo LatentInfo,string Name,string Notes,FAutomationScreenshotOptions Options) {}
	public void TakeAutomationScreenshotAtCamera(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject Camera,string NameOverride,string Notes,FAutomationScreenshotOptions Options) {}
	public void TakeAutomationScreenshotOfUI(UObject WorldContextObject,FLatentActionInfo LatentInfo,string Name,FAutomationScreenshotOptions Options) {}
	public void EnableStatGroup(UObject WorldContextObject,string GroupName) {}
	public void DisableStatGroup(UObject WorldContextObject,string GroupName) {}
	public float GetStatIncAverage(string StatName) { return default; }
	public float GetStatIncMax(string StatName) { return default; }
	public float GetStatExcAverage(string StatName) { return default; }
	public float GetStatExcMax(string StatName) { return default; }
	public float GetStatCallCount(string StatName) { return default; }
	public bool AreAutomatedTestsRunning() { return default; }
	public void AutomationWaitForLoading(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAutomationWaitForLoadingOptions Options) {}
	public UObject TakeHighResScreenshot(int ResX,int ResY,string Filename,UObject Camera/*=nullptr*/,bool bMaskEnabled/*=false*/,bool bCaptureHDR/*=false*/,EComparisonTolerance ComparisonTolerance/*=EComparisonTolerance.Low*/,string ComparisonNotes/*=TEXT("")*/,float Delay/*=0.0f*/) { return default; }
	public bool CompareImageAgainstReference(string ImageFilePath,string ComparisonName/*=TEXT("")*/,EComparisonTolerance ComparisonTolerance/*=EComparisonTolerance.Low*/,string ComparisonNotes/*=TEXT("")*/,UObject WorldContextObject/*=nullptr*/) { return default; }
	public void AddTestTelemetryData(string DataPoint,float Measurement,string Context/*=TEXT("")*/) {}
	public void SetTestTelemetryStorage(string StorageName) {}
	public FAutomationScreenshotOptions GetDefaultScreenshotOptionsForGameplay(EComparisonTolerance Tolerance/*=EComparisonTolerance.Low*/,float Delay/*=0.2f*/) { return default; }
	public FAutomationScreenshotOptions GetDefaultScreenshotOptionsForRendering(EComparisonTolerance Tolerance/*=EComparisonTolerance.Low*/,float Delay/*=0.2f*/) { return default; }
	public void AddExpectedLogError(string ExpectedPatternString,int Occurrences/*=1*/,bool ExactMatch/*=false*/) {}
	public void SetScalabilityQualityLevelRelativeToMax(UObject WorldContextObject,int Value/*=1*/) {}
	public void SetScalabilityQualityToEpic(UObject WorldContextObject) {}
	public void SetScalabilityQualityToLow(UObject WorldContextObject) {}
	public void SetEditorViewportViewMode(EViewModeIndex Index) {}
	public void SetEditorViewportVisualizeBuffer(string BufferName) {}
}
