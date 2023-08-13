namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_GetAllSessionsResponse {
	public TArray<FConcertSessionInfo> LiveSessions;
	public TArray<FConcertSessionInfo> ArchivedSessions;
}
