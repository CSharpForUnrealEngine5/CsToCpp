#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSessionTypes.h")]
///<summary>Summary for a lock activity entry in a Concert Sync Session</summary>
public partial struct FConcertSyncLockActivitySummary {
// ConcertSyncLockActivitySummary
	public EConcertSyncLockEventType LockEventType;
	public string PrimaryResourceName;
	public string PrimaryPackageName;
	public int NumResources;
}
