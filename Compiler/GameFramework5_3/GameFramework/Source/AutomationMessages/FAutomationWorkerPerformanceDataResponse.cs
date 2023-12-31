namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that responds to PerformanceDataRequest.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerPerformanceDataResponse {
	public bool bSuccess;
	public string ErrorMessage;
}
