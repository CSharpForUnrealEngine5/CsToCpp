#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Create an archived copy of a live session.</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_ArchiveSessionRequest {
	public FGuid SessionId;
	public string ArchiveNameOverride;
	public string UserName;
	public string DeviceName;
	public FConcertSessionFilter SessionFilter;
}
