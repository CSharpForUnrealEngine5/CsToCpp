#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationControllerManager.h")]
public partial struct FAutomatedTestPassResults {
// AutomatedTestPassResults
	public TArray<FAutomationDeviceInfo> Devices;
	public FDateTime ReportCreatedOn;
	public int Succeeded;
	public int SucceededWithWarnings;
	public int Failed;
	public int NotRun;
	public int InProcess;
	public float TotalDuration;
	public bool ComparisonExported;
	public string ComparisonExportDirectory;
	public TArray<FAutomatedTestResult> Tests;
}
