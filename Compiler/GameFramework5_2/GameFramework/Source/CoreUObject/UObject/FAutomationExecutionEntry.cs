#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Information about the execution of an automation task (mirrored in AutomationEvent.h).</summary>
public partial struct FAutomationExecutionEntry {
// AutomationExecutionEntry
	public FAutomationEvent Event;
	public string Filename;
	public int LineNumber;
	public FDateTime Timestamp;
}
