#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for an activity entry in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncActivity {
	public long ActivityId;
	public bool bIgnored;
	public EConcertSyncActivityFlags Flags;
	public FGuid EndpointId;
	public FDateTime EventTime;
	public EConcertSyncActivityEventType EventType;
	public long EventId;
	public FConcertSessionSerializedPayload EventSummary;
}
