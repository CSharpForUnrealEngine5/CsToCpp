#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a lock event in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncLockEvent {
	public EConcertSyncLockEventType LockEventType;
	public TArray<string> ResourceNames;
}
