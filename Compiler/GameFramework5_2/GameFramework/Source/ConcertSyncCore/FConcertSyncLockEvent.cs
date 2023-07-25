#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSessionTypes.h")]
///<summary>Data for a lock event in a Concert Sync Session</summary>
public partial struct FConcertSyncLockEvent {
// ConcertSyncLockEvent
	public EConcertSyncLockEventType LockEventType;
	public TArray<string> ResourceNames;
}
