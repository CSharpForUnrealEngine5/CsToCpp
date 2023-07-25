#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertSession_JoinSessionResultEvent {
// ConcertSession_JoinSessionResultEvent
	public FGuid SessionServerEndpointId;
	public EConcertConnectionResult ConnectionResult;
	public TArray<FConcertSessionClientInfo> SessionClients;
}
