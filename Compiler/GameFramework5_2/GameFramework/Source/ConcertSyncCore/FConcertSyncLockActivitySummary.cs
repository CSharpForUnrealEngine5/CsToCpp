#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Summary for a lock activity entry in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncLockActivitySummary {
	public EConcertSyncLockEventType LockEventType;
	public string PrimaryResourceName;
	public string PrimaryPackageName;
	public int NumResources;
}
