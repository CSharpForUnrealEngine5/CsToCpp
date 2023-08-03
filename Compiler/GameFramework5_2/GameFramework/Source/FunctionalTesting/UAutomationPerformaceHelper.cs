#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class for use with functional tests which provides various performance measuring features.</summary>
[CppInclude("FunctionalTest.h")]
public partial class UAutomationPerformaceHelper : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Begin basic stat recording</summary>
	public  void Tick(float DeltaSeconds) {}
	///<summary>Adds a sample to the stats counters for the current performance stats record.</summary>
	public  void Sample(float DeltaSeconds) {}
	///<summary>Begins recording a new named performance stats record. We start by recording the baseline</summary>
	public  void BeginRecordingBaseline(string RecordName) {}
	///<summary>Stops recording the baseline and moves to the main record.</summary>
	public  void EndRecordingBaseline() {}
	///<summary>Begins recording a new named performance stats record. We start by recording the baseline.</summary>
	public  void BeginRecording(string RecordName,float InGPUBudget,float InRenderThreadBudget,float InGameThreadBudget) {}
	///<summary>Stops recording performance stats.</summary>
	public  void EndRecording() {}
	///<summary>Writes the current set of performance stats records to a csv file in the profiling directory. An additional directory and an extension override can also be used.</summary>
	public  void WriteLogFile(string CaptureDir,string CaptureExtension) {}
	///<summary>Returns true if this stats tracker is currently recording performance stats.</summary>
	public  bool IsRecording() { return default; }
	///<summary>Does any init work across all tests..</summary>
	public  void OnBeginTests() {}
	///<summary>Does any final work needed as all tests are complete.</summary>
	public  void OnAllTestsComplete() {}
	///<summary>IsCurrentRecordWithinGPUBudget</summary>
	public  bool IsCurrentRecordWithinGPUBudget() { return default; }
	///<summary>IsCurrentRecordWithinGameThreadBudget</summary>
	public  bool IsCurrentRecordWithinGameThreadBudget() { return default; }
	///<summary>IsCurrentRecordWithinRenderThreadBudget</summary>
	public  bool IsCurrentRecordWithinRenderThreadBudget() { return default; }
	///<summary>Communicates with external profiler to being a CPU capture.</summary>
	public  void StartCPUProfiling() {}
	///<summary>Communicates with external profiler to end a CPU capture.</summary>
	public  void StopCPUProfiling() {}
	///<summary>Will trigger a GPU trace next time the current test falls below GPU budget.</summary>
	public  void TriggerGPUTraceIfRecordFallsBelowBudget() {}
	///<summary>Begins recording stats to a file.</summary>
	public  void BeginStatsFile(string RecordName) {}
	///<summary>Ends recording stats to a file.</summary>
	public  void EndStatsFile() {}
}
