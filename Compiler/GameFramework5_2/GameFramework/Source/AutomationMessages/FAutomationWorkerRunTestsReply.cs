#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is sent in response to FAutomationWorkerRunTests.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerRunTestsReply {
	public string TestName;
	public TArray<FAutomationExecutionEntry> Entries;
	public int WarningTotal;
	public int ErrorTotal;
	public float Duration;
	public uint ExecutionCount;
	public EAutomationState State;
}
