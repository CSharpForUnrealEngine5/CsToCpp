#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Used to copy a live session or restore an archived one.</summary>
public partial struct FConcertAdmin_CopySessionRequest {
// ConcertAdmin_CopySessionRequest
	public FGuid SessionId;
	public string SessionName;
	public FConcertClientInfo OwnerClientInfo;
	public FConcertSessionSettings SessionSettings;
	public FConcertSessionVersionInfo VersionInfo;
	public FConcertSessionFilter SessionFilter;
}
