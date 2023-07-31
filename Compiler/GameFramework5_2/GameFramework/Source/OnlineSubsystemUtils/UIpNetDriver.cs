#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IpNetDriver.h")]
public partial class UIpNetDriver : UNetDriver {
	///<summary>Should port unreachable messages be logged</summary>
	public bool LogPortUnreach;
	///<summary>Does the game allow clients to remain after receiving ICMP port unreachable errors (handles flakey connections)</summary>
	public bool AllowPlayerPortUnreach;
	///<summary>Number of ports which will be tried if current one is not available for binding (i.e. if told to bind to port N, will try from N to N+MaxPortCountToTry inclusive)</summary>
	public uint MaxPortCountToTry;
	///<summary>Number of bytes that will be passed to FSocket::SetReceiveBufferSize when initializing a server.</summary>
	public uint ServerDesiredSocketReceiveBufferBytes;
	///<summary>Number of bytes that will be passed to FSocket::SetSendBufferSize when initializing a server.</summary>
	public uint ServerDesiredSocketSendBufferBytes;
	///<summary>Number of bytes that will be passed to FSocket::SetReceiveBufferSize when initializing a client.</summary>
	public uint ClientDesiredSocketReceiveBufferBytes;
	///<summary>Number of bytes that will be passed to FSocket::SetSendBufferSize when initializing a client.</summary>
	public uint ClientDesiredSocketSendBufferBytes;
	///<summary>Maximum time in seconds the TickDispatch can loop on received socket data</summary>
	public double MaxSecondsInReceive;
	///<summary>Nb of packets to wait before testing if the receive time went over MaxSecondsInReceive</summary>
	public int NbPacketsBetweenReceiveTimeTest;
	///<summary>The amount of time to wait in seconds until we consider a connection to a resolution result as timed out</summary>
	public float ResolutionConnectionTimeout;
}
