#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Request to sync an event that was partially synced on the client but for which the full data is required for inspection. FConcertSyncEventResponse is the corresponding response.</summary>
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertSyncEventRequest {
	public EConcertSyncActivityEventType EventType;
	public long EventId;
}
