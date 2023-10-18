namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is published to find automation workers.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerFindWorkers {
	public int Changelist;
	public string GameName;
	public string ProcessName;
	public FGuid SessionId;
}
