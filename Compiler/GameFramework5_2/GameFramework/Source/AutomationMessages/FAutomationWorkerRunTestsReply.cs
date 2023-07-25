#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that is sent in response to FAutomationWorkerRunTests.</summary>
public partial struct FAutomationWorkerRunTestsReply {
// AutomationWorkerRunTestsReply
	public string TestName;
	public TArray<FAutomationExecutionEntry> Entries;
	public int WarningTotal;
	public int ErrorTotal;
	public float Duration;
	public uint ExecutionCount;
	public EAutomationState State;
}
