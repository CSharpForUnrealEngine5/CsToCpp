#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
///<summary>Request to sync an event that was partially synced on the client but for which the full data is required for inspection. FConcertSyncEventResponse is the corresponding response.</summary>
public partial struct FConcertSyncEventRequest {
// ConcertSyncEventRequest
	public EConcertSyncActivityEventType EventType;
	public long EventId;
}
