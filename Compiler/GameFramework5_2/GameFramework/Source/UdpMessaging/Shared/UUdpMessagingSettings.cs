namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/UdpMessagingSettings.h")]
public partial class UUdpMessagingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether UDP messaging is enabled by default. If false -messaging will need to be added</summary>
	public bool EnabledByDefault;
	///<summary>Whether the UDP transport channel is enabled.</summary>
	public bool EnableTransport;
	///<summary>Whether the UDP transport channel should try to auto repair when in error.</summary>
	public bool bAutoRepair;
	///<summary>Maximum sustained transmission rate in Gbit / s.</summary>
	public float MaxSendRate;
	///<summary>The number of consecutive attempt the auto repair routine will try to repair.</summary>
	public uint AutoRepairAttemptLimit;
	///<summary>The buffer size for the working send queues. Each node connections</summary>
	public ushort WorkQueueSize;
	///<summary>Whether to stop the transport service when the application deactivates, and restart it when the application is reactivated</summary>
	public bool bStopServiceWhenAppDeactivates;
	///<summary>The IP endpoint to listen to and send packets from.</summary>
	public string UnicastEndpoint;
	///<summary>The IP endpoint to send multicast packets to.</summary>
	public string MulticastEndpoint;
	///<summary>The format used to serialize the UDP message payload.</summary>
	public EUdpMessageFormat MessageFormat;
	///<summary>The time-to-live (TTL) for sent multicast packets.</summary>
	public byte MulticastTimeToLive;
	///<summary>The IP endpoints of static devices.</summary>
	public TArray<string> StaticEndpoints;
	///<summary>List of IP addresses that are banned from communicating with this client.</summary>
	public TArray<string> ExcludedEndpoints;
	///<summary>Whether the UDP tunnel is enabled.</summary>
	public bool EnableTunnel;
	///<summary>The local IP endpoint to listen to and send packets from.</summary>
	public string TunnelUnicastEndpoint;
	///<summary>The IP endpoint to send multicast packets to.</summary>
	public string TunnelMulticastEndpoint;
	///<summary>The IP endpoints of remote tunnel nodes.</summary>
	public TArray<string> RemoteTunnelEndpoints;
}
