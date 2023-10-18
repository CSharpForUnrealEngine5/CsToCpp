namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/QuicMessagingSettings.h")]
public partial class UQuicMessagingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether Quic messaging is enabled by default. If false -messaging will need to be added</summary>
	public bool EnabledByDefault;
	///<summary>Whether the Quic transport channel is enabled.</summary>
	public bool EnableTransport;
	///<summary>Whether the Quic transport channel should try to auto repair when in error.</summary>
	public bool bAutoRepair;
	///<summary>Whether the QUIC transport endpoint is a client (true) or a server (false)</summary>
	public bool bIsClient;
	///<summary>Whether encryption should be used after the quic handshake</summary>
	public bool bEncryption;
	///<summary>Timeout in seconds when the remote endpoint cannot be discovered.</summary>
	public uint DiscoveryTimeoutSeconds;
	///<summary>Whether server side authentication is enabled</summary>
	public bool bAuthEnabled;
	///<summary>Maximum authentication message size for server side authentication</summary>
	public uint MaxAuthenticationMessageSize;
	///<summary>Whether server has a cooldown for connection attempts.</summary>
	public bool bConnectionCooldownEnabled;
	///<summary>Maximum number of connection attempts until the cooldown is triggered.</summary>
	public uint ConnectionCooldownMaxAttempts;
	///<summary>Time period in seconds within which the maximum attempts must happen.</summary>
	public uint ConnectionCooldownPeriodSeconds;
	///<summary>Connection cooldown in seconds used with exponential backoff.</summary>
	public uint ConnectionCooldownSeconds;
	///<summary>Maximum connection cooldown in seconds for exponential backoff.</summary>
	public uint ConnectionCooldownMaxSeconds;
	///<summary>Whether the QUIC client should verify the server certificate</summary>
	public bool bClientVerificationEnabled;
	///<summary>Server certificate to encrypt QUIC transport</summary>
	public string QuicServerCertificate;
	///<summary>Server private key to encrypt QUIC transport</summary>
	public string QuicServerPrivateKey;
	///<summary>Guid of this endpoint</summary>
	public FGuid EndpointGuid;
	///<summary>The number of consecutive attempt the auto repair routine will try to repair.</summary>
	public uint AutoRepairAttemptLimit;
	///<summary>Whether to stop the transport service when the application deactivates, and restart it when the application is reactivated</summary>
	public bool bStopServiceWhenAppDeactivates;
	///<summary>The IP endpoint to listen to and send packets from.</summary>
	public string UnicastEndpoint;
	///<summary>The format used to serialize the Quic message payload.</summary>
	public EQuicMessageFormat MessageFormat;
	///<summary>The IP endpoints of static devices.</summary>
	public TArray<string> StaticEndpoints;
}
