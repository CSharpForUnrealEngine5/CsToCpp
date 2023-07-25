#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that handles both storing and requesting ground truth data.</summary>
public partial struct FAutomationWorkerTestDataRequest {
// AutomationWorkerTestDataRequest
	public string DataType;
	public string DataPlatform;
	public string DataTestName;
	public string DataName;
	public string JsonData;
}
