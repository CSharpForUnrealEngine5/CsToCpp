#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_GetAllSessionsResponse {
// ConcertAdmin_GetAllSessionsResponse
	public TArray<FConcertSessionInfo> LiveSessions;
	public TArray<FConcertSessionInfo> ArchivedSessions;
}
