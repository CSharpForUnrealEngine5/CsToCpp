#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertPlaySessionEvent {
// ConcertPlaySessionEvent
	public EConcertPlaySessionEventType EventType;
	public FGuid PlayEndpointId;
	public string PlayPackageName;
	public bool bIsSimulating;
}
