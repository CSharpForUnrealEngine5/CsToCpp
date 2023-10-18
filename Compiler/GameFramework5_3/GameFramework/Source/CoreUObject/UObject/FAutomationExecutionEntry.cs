namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about the execution of an automation task (mirrored in AutomationEvent.h).</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FAutomationExecutionEntry {
	public FAutomationEvent Event;
	public string Filename;
	public int LineNumber;
	public FDateTime Timestamp;
}
