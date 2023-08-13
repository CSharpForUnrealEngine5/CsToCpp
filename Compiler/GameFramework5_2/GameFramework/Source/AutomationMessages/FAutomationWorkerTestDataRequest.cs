namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that handles both storing and requesting ground truth data.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerTestDataRequest {
	public string DataType;
	public string DataPlatform;
	public string DataTestName;
	public string DataName;
	public string JsonData;
}
