#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationControllerManager.h")]
public partial struct FAutomatedTestResult {
// AutomatedTestResult
	public string TestDisplayName;
	public string FullTestPath;
	public EAutomationState State;
	public TArray<string> DeviceInstance;
	public float Duration;
	public FDateTime DateTime;
	public TArray<FAutomationExecutionEntry> Entries;
	public int Warnings;
	public int Errors;
	public TArray<FAutomationArtifact> Artifacts;
}
