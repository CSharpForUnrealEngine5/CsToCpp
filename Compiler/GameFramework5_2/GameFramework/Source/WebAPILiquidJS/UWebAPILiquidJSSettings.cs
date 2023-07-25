#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPILiquidJSSettings.h")]
public partial class UWebAPILiquidJSSettings : UDeveloperSettings {
// WebAPILiquidJSSettings
	public uint Port;
	public bool bForceWebAppBuildAtStartup;
	public bool bWebAppLogRequestDuration;
	public bool bAutoStartWebServer;
	public bool bAutoStartWebSocketServer;
	public uint HttpServerPort;
	public uint WebSocketServerPort;
	public string ServiceUrl;
	public string FormattedServiceUrl;
	public uint FormattedWithPort;
}
