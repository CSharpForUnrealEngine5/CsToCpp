namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_CreateSessionRequest {
	public string SessionName;
	public FConcertClientInfo OwnerClientInfo;
	public FConcertSessionSettings SessionSettings;
	public FConcertSessionVersionInfo VersionInfo;
}
