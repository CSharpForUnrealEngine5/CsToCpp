#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/TcpMessagingSettings.h")]
public partial class UTcpMessagingSettings : UObject {
// TcpMessagingSettings
	public bool EnableTransport;
	public string ListenEndpoint;
	public TArray<string> ConnectToEndpoints;
	public int ConnectionRetryDelay;
	public int ConnectionRetryPeriod;
	public bool bStopServiceWhenAppDeactivates;
}
