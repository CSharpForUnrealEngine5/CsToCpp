namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertPlaySessionEvent {
	public EConcertPlaySessionEventType EventType;
	public FGuid PlayEndpointId;
	public string PlayPackageName;
	public bool bIsSimulating;
}
