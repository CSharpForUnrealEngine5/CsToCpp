namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for requesting available automation tests from a worker.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerRequestTests {
	public bool DeveloperDirectoryIncluded;
	public uint RequestedTestFlags;
}
