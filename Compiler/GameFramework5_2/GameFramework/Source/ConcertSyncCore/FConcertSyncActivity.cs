#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSessionTypes.h")]
///<summary>Data for an activity entry in a Concert Sync Session</summary>
public partial struct FConcertSyncActivity {
// ConcertSyncActivity
	public long ActivityId;
	public bool bIgnored;
	public EConcertSyncActivityFlags Flags;
	public FGuid EndpointId;
	public FDateTime EventTime;
	public EConcertSyncActivityEventType EventType;
	public long EventId;
	public FConcertSessionSerializedPayload EventSummary;
}
