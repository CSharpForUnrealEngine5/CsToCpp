namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_GetSessionActivitiesResponse {
	public TArray<FConcertSessionSerializedPayload> Activities;
	public TMap<FGuid,FConcertClientInfo> EndpointClientInfoMap;
}
