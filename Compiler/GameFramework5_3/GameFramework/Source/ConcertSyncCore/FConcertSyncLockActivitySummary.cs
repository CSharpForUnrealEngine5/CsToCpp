namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Summary for a lock activity entry in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncLockActivitySummary {
	public EConcertSyncLockEventType LockEventType;
	public FName PrimaryResourceName;
	public FName PrimaryPackageName;
	public int NumResources;
}
