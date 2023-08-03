#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPILiquidJSSettings.h")]
public partial class UWebAPILiquidJSSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The web app http port.</summary>
	public uint Port;
	///<summary>Should force a build of the WebApp at startup.</summary>
	public bool bForceWebAppBuildAtStartup;
	///<summary>Should WebApp log timing.</summary>
	public bool bWebAppLogRequestDuration;
	///<summary>Whether web server is started automatically.</summary>
	public bool bAutoStartWebServer;
	///<summary>Whether web socket server is started automatically.</summary>
	public bool bAutoStartWebSocketServer;
	///<summary>The HTTP server&#39;s port.</summary>
	public uint HttpServerPort;
	///<summary>The WebSocket server&#39;s port.</summary>
	public uint WebSocketServerPort;
	///<summary>The web app url.</summary>
	public string ServiceUrl;
	///<summary>Cached formatted Url.</summary>
	public string FormattedServiceUrl;
	///<summary>What port the formatted Url was created with, used to re-cache on port change.</summary>
	public uint FormattedWithPort;
}
