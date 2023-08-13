namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertSession_JoinSessionResultEvent {
	public FGuid SessionServerEndpointId;
	public EConcertConnectionResult ConnectionResult;
	public TArray<FConcertSessionClientInfo> SessionClients;
}
