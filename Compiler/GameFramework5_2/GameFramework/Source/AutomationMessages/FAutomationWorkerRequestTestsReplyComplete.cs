#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Returns list of all tests</summary>
public partial struct FAutomationWorkerRequestTestsReplyComplete {
// AutomationWorkerRequestTestsReplyComplete
	public TArray<FAutomationWorkerSingleTestReply> Tests;
}
