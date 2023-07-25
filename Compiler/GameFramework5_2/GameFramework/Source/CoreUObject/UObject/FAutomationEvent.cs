#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Event emitted by automation system (mirrored in AutomationEvent.h).</summary>
public partial struct FAutomationEvent {
// AutomationEvent
	public EAutomationEventType Type;
	public string Message;
	public string Context;
	public FGuid Artifact;
}
