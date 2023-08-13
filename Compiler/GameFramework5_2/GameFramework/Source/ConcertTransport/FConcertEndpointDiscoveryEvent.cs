namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Special event message base struct that is also caught by the endpoint to discover remote endpoint before passing it to handlers</summary>
[CppInclude("ConcertTransportMessages.h")]
public partial struct FConcertEndpointDiscoveryEvent {
	public EConcertMessageVersion ConcertProtocolVersion;
}
