#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertWorkspaceSyncRequestedEvent {
// ConcertWorkspaceSyncRequestedEvent
	public long FirstActivityIdToSync;
	public long LastActivityIdToSync;
	public bool bEnableLiveSync;
}
