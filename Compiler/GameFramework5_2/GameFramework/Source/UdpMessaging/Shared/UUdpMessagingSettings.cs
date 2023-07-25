#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/UdpMessagingSettings.h")]
public partial class UUdpMessagingSettings : UObject {
// UdpMessagingSettings
	public bool EnabledByDefault;
	public bool EnableTransport;
	public bool bAutoRepair;
	public float MaxSendRate;
	public uint AutoRepairAttemptLimit;
	public ushort WorkQueueSize;
	public bool bStopServiceWhenAppDeactivates;
	public string UnicastEndpoint;
	public string MulticastEndpoint;
	public EUdpMessageFormat MessageFormat;
	public byte MulticastTimeToLive;
	public TArray<string> StaticEndpoints;
	public TArray<string> ExcludedEndpoints;
	public bool EnableTunnel;
	public string TunnelUnicastEndpoint;
	public string TunnelMulticastEndpoint;
	public TArray<string> RemoteTunnelEndpoints;
}
