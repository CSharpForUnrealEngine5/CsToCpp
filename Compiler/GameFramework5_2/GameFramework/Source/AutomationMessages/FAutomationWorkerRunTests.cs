#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message to request the running of automation tests on a worker.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerRunTests {
	public uint ExecutionCount;
	public int RoleIndex;
	public string TestName;
	public string BeautifiedTestName;
	public string FullTestPath;
	public bool bSendAnalytics;
}
