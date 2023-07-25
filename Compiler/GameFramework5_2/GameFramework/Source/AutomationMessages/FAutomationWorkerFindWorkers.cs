#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that is published to find automation workers.</summary>
public partial struct FAutomationWorkerFindWorkers {
// AutomationWorkerFindWorkers
	public int Changelist;
	public string GameName;
	public string ProcessName;
	public FGuid SessionId;
}
