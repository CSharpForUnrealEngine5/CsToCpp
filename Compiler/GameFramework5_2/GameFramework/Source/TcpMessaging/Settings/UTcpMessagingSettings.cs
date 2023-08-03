#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/TcpMessagingSettings.h")]
public partial class UTcpMessagingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the TCP transport channel is enabled</summary>
	public bool EnableTransport;
	///<summary>The IP endpoint to listen for incoming connections.</summary>
	public string ListenEndpoint;
	///<summary>The IP endpoints to try to establish outgoing connection to.</summary>
	public TArray<string> ConnectToEndpoints;
	///<summary>Delay time between attempts to re-establish outgoing connections that become disconnected or fail to connect</summary>
	public int ConnectionRetryDelay;
	///<summary>Period time during which attempts to re-establish outgoing connections that become disconnected or fail to connect</summary>
	public int ConnectionRetryPeriod;
	///<summary>Whether to stop the transport service when the application deactivates, and restart it when the application is reactivated</summary>
	public bool bStopServiceWhenAppDeactivates;
}
