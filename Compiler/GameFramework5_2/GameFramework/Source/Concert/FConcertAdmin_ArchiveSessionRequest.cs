#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Create an archived copy of a live session.</summary>
public partial struct FConcertAdmin_ArchiveSessionRequest {
// ConcertAdmin_ArchiveSessionRequest
	public FGuid SessionId;
	public string ArchiveNameOverride;
	public string UserName;
	public string DeviceName;
	public FConcertSessionFilter SessionFilter;
}
