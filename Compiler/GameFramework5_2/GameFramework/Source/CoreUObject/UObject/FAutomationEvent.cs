namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event emitted by automation system (mirrored in AutomationEvent.h).</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FAutomationEvent {
	public EAutomationEventType Type;
	public string Message;
	public string Context;
	public FGuid Artifact;
}
