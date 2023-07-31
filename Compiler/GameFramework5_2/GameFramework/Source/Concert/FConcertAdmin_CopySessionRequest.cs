#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to copy a live session or restore an archived one.</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_CopySessionRequest {
	public FGuid SessionId;
	public string SessionName;
	public FConcertClientInfo OwnerClientInfo;
	public FConcertSessionSettings SessionSettings;
	public FConcertSessionVersionInfo VersionInfo;
	public FConcertSessionFilter SessionFilter;
}
