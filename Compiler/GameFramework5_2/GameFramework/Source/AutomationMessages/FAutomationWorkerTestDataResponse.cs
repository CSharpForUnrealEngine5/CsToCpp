#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that responds to TestDataRequests.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerTestDataResponse {
	public string JsonData;
	public bool bIsNew;
}
