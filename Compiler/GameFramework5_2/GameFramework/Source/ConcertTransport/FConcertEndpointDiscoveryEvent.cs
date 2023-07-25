#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Special event message base struct that is also caught by the endpoint to discover remote endpoint before passing it to handlers</summary>
public partial struct FConcertEndpointDiscoveryEvent {
// ConcertEndpointDiscoveryEvent
	public EConcertMessageVersion ConcertProtocolVersion;
}
