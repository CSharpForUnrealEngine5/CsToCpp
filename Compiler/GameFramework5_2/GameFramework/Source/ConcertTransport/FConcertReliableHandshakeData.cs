#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Handshake used to negotiate a reliable channel between endpoints (also uses the ReliableChannelId from the base message)</summary>
public partial struct FConcertReliableHandshakeData {
// ConcertReliableHandshakeData
	public EConcertReliableHandshakeState HandshakeState;
	public ushort ReliableChannelId;
	public ushort NextMessageIndex;
	public long EndpointTimeoutTick;
}
