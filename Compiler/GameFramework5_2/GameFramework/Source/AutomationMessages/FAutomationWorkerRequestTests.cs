#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message for requesting available automation tests from a worker.</summary>
public partial struct FAutomationWorkerRequestTests {
// AutomationWorkerRequestTests
	public bool DeveloperDirectoryIncluded;
	public uint RequestedTestFlags;
}
