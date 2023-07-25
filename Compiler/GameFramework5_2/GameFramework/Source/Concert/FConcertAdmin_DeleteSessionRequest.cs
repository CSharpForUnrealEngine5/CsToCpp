#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Delete an archived or live session.</summary>
public partial struct FConcertAdmin_DeleteSessionRequest {
// ConcertAdmin_DeleteSessionRequest
	public FGuid SessionId;
	public string UserName;
	public string DeviceName;
}
