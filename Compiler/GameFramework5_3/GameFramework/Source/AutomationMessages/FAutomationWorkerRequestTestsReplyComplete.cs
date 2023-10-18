namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns list of all tests</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerRequestTestsReplyComplete {
	public TArray<FAutomationWorkerSingleTestReply> Tests;
}
