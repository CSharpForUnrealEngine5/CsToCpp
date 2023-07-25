#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlSettings.h")]
///<summary>Global remote control settings</summary>
public partial class URemoteControlSettings : UDeveloperSettings {
// RemoteControlSettings
	public bool bProtocolsGenerateTransactions;
	public string RemoteControlWebInterfaceBindAddress;
	public uint RemoteControlWebInterfacePort;
	public bool bForceWebAppBuildAtStartup;
	public bool bWebAppLogRequestDuration;
	public bool bAutoStartWebServer;
	public bool bAutoStartWebSocketServer;
	public uint RemoteControlHttpServerPort;
	public string RemoteControlWebsocketServerBindAddress;
	public uint RemoteControlWebSocketServerPort;
	public bool bDisplayInEditorOnlyWarnings;
	public float TreeBindingSplitRatio;
	public bool bUseRebindingContext;
	public bool bIgnoreProtectedCheck;
	public bool bIgnoreGetterSetterCheck;
	public bool bIgnoreWarnings;
	public bool bRestrictServerAccess;
	public bool bEnableRemotePythonExecution;
	public TSet<FRCNetworkAddressRange> AllowlistedClients;
	public string AllowedOrigin;
	public bool bEnforcePassphraseForRemoteClients;
	public TArray<FRCPassphrase> Passphrases;
	public bool bShowPassphraseDisabledWarning;
	public bool bSecuritySettingsReviewed;
}
