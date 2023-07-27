#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTest.h")]
///<summary>Class for use with functional tests which provides various performance measuring features.</summary>
public partial class UAutomationPerformaceHelper : UObject {
// AutomationPerformaceHelper
	public  void Tick(float DeltaSeconds) {}
	public  void Sample(float DeltaSeconds) {}
	public  void BeginRecordingBaseline(string RecordName) {}
	public  void EndRecordingBaseline() {}
	public  void BeginRecording(string RecordName,float InGPUBudget,float InRenderThreadBudget,float InGameThreadBudget) {}
	public  void EndRecording() {}
	public  void WriteLogFile(string CaptureDir,string CaptureExtension) {}
	public  bool IsRecording() { return default; }
	public  void OnBeginTests() {}
	public  void OnAllTestsComplete() {}
	public  bool IsCurrentRecordWithinGPUBudget() { return default; }
	public  bool IsCurrentRecordWithinGameThreadBudget() { return default; }
	public  bool IsCurrentRecordWithinRenderThreadBudget() { return default; }
	public  void StartCPUProfiling() {}
	public  void StopCPUProfiling() {}
	public  void TriggerGPUTraceIfRecordFallsBelowBudget() {}
	public  void BeginStatsFile(string RecordName) {}
	public  void EndStatsFile() {}
}
