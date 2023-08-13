namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Global remote control settings</summary>
[CppInclude("RemoteControlSettings.h")]
public partial class URemoteControlSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Should transactions be generated for events received through protocols (ie. MIDI, DMX etc.)</summary>
	public bool bProtocolsGenerateTransactions;
	///<summary>The remote control web app bind address.</summary>
	public string RemoteControlWebInterfaceBindAddress;
	///<summary>The remote control web app http port.</summary>
	public uint RemoteControlWebInterfacePort;
	///<summary>Should force a build of the WebApp at startup.</summary>
	public bool bForceWebAppBuildAtStartup;
	///<summary>Should WebApp log timing.</summary>
	public bool bWebAppLogRequestDuration;
	///<summary>Whether web server is started automatically.</summary>
	public bool bAutoStartWebServer;
	///<summary>Whether web socket server is started automatically.</summary>
	public bool bAutoStartWebSocketServer;
	///<summary>The web remote control HTTP server&#39;s port.</summary>
	public uint RemoteControlHttpServerPort;
	///<summary>The address to bind the websocket server to. 0.0.0.0 will open the connection to everyone on your network, while 127.0.0.1 will only allow local requests to come through.</summary>
	public string RemoteControlWebsocketServerBindAddress;
	///<summary>The web remote control WebSocket server&#39;s port.</summary>
	public uint RemoteControlWebSocketServerPort;
	///<summary>Show a warning icon for exposed editor-only fields.</summary>
	public bool bDisplayInEditorOnlyWarnings;
	///<summary>The split widget control ratio between entity tree and details/protocol binding list.</summary>
	public float TreeBindingSplitRatio;
	///<summary>bUseRebindingContext</summary>
	public bool bUseRebindingContext;
	///<summary>bIgnoreProtectedCheck</summary>
	public bool bIgnoreProtectedCheck;
	///<summary>bIgnoreGetterSetterCheck</summary>
	public bool bIgnoreGetterSetterCheck;
	///<summary>bIgnoreWarnings</summary>
	public bool bIgnoreWarnings;
	///<summary>Whether to restrict access to a list of hostname/IPs in the AllowedOrigins setting.</summary>
	public bool bRestrictServerAccess;
	///<summary>Enable remote python execution, enabling this could open you open to vulnerabilities if an outside actor has access to your server.</summary>
	public bool bEnableRemotePythonExecution;
	///<summary>List of IP Addresses that are allowed to access the Web API without authentication.</summary>
	public TSet<FRCNetworkAddressRange> AllowlistedClients;
	///<summary>Origin that can make requests to the remote control server. Should contain the hostname or IP of the server making requests to remote control. ie. &quot;http://yourdomain.com&quot;, or &quot;*&quot; to allow all origins.</summary>
	public string AllowedOrigin;
	///<summary>Controls whether a passphrase should be required when remote control is accessed by a client outside of localhost.</summary>
	public bool bEnforcePassphraseForRemoteClients;
	///<summary>List of passphrases used for accessing remote control outside of localhost.</summary>
	public TArray<FRCPassphrase> Passphrases;
	///<summary>Whether the User should be warned that Passphrase usage is disabled or now. Initially activated</summary>
	public bool bShowPassphraseDisabledWarning;
	///<summary>bSecuritySettingsReviewed</summary>
	public bool bSecuritySettingsReviewed;
}
