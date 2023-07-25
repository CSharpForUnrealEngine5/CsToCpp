#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_GetSessionActivitiesResponse {
// ConcertAdmin_GetSessionActivitiesResponse
	public TArray<FConcertSessionSerializedPayload> Activities;
	public TMap<FGuid,FConcertClientInfo> EndpointClientInfoMap;
}
