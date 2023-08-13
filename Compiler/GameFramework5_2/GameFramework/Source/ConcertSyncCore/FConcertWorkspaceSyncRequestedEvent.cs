namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertWorkspaceSyncRequestedEvent {
	public long FirstActivityIdToSync;
	public long LastActivityIdToSync;
	public bool bEnableLiveSync;
}
