#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for requesting available automation tests from a worker.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerRequestTests {
	public bool DeveloperDirectoryIncluded;
	public uint RequestedTestFlags;
}
