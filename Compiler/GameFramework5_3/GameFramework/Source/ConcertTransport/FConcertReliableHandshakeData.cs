namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handshake used to negotiate a reliable channel between endpoints (also uses the ReliableChannelId from the base message)</summary>
[CppInclude("ConcertTransportMessages.h")]
public partial struct FConcertReliableHandshakeData {
	public EConcertReliableHandshakeState HandshakeState;
	public ushort ReliableChannelId;
	public ushort NextMessageIndex;
	public long EndpointTimeoutTick;
}
