namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Handshake codes used during reliable channel negotiation</summary>
public enum EConcertReliableHandshakeState {
	None=0,
	Negotiate=1,
	Success=2,
}
