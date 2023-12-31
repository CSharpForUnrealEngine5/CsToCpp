namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Delete an archived or live session.</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_DeleteSessionRequest {
	public FGuid SessionId;
	public string UserName;
	public string DeviceName;
}
