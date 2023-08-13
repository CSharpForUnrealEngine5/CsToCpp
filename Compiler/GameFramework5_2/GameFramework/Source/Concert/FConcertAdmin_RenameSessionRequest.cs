namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rename a session.</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_RenameSessionRequest {
	public FGuid SessionId;
	public string NewName;
	public string UserName;
	public string DeviceName;
}
