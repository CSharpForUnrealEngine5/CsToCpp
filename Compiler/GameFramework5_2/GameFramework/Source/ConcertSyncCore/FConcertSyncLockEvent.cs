namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a lock event in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncLockEvent {
	public EConcertSyncLockEventType LockEventType;
	public TArray<FName> ResourceNames;
}
