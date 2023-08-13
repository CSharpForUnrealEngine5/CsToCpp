namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_FindSessionRequest {
	public FGuid SessionId;
	public FConcertClientInfo OwnerClientInfo;
	public FConcertSessionSettings SessionSettings;
	public FConcertSessionVersionInfo VersionInfo;
}
