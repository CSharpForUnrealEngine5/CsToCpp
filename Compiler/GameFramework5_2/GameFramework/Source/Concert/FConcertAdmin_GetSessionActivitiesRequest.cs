#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_GetSessionActivitiesRequest {
// ConcertAdmin_GetSessionActivitiesRequest
	public FGuid SessionId;
	public long FromActivityId;
	public long ActivityCount;
	public bool bIncludeDetails;
}
