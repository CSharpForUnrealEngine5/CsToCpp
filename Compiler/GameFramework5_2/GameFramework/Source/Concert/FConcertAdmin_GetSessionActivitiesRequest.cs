namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_GetSessionActivitiesRequest {
	public FGuid SessionId;
	public long FromActivityId;
	public long ActivityCount;
	public bool bIncludeDetails;
}
