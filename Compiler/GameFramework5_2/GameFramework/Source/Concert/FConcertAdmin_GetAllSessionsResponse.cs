#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_GetAllSessionsResponse {
	public TArray<FConcertSessionInfo> LiveSessions;
	public TArray<FConcertSessionInfo> ArchivedSessions;
}
