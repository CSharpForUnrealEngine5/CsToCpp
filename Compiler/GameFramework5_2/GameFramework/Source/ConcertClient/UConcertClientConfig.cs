#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertClientSettings.h")]
public partial class UConcertClientConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>True if this client should be &quot;headless&quot;? (ie, not display any UI).</summary>
	public bool bIsHeadless;
	///<summary>True if the Multi-User module should install shortcut button and its drop-down menu in the level editor toolbar.</summary>
	public bool bInstallEditorToolbarButton;
	///<summary>Automatically connect or create default session on default server.</summary>
	public bool bAutoConnect;
	///<summary>If auto-connect is on, retry connecting to the default server/session until it succeeds or the user cancels.</summary>
	public bool bRetryAutoConnectOnError;
	///<summary>Determines which server executable with be launched:</summary>
	public EConcertServerType ServerType;
	///<summary>Default server url (just a name for now) to look for on auto or default connect.</summary>
	public string DefaultServerURL;
	///<summary>Default session name to look for on auto connect or default connect.</summary>
	public string DefaultSessionName;
	///<summary>If this client create the default session, should the session restore a saved session.</summary>
	public string DefaultSessionToRestore;
	///<summary>If this client create the default session, should the session data be saved when it&#39;s deleted.</summary>
	public string DefaultSaveSessionAs;
	///<summary>A list of roles that should enter multi-user in read-only mode. If a role is in both SendOnlyAssignment and</summary>
	public FGameplayTagContainer ReadOnlyAssignment;
	///<summary>A list of roles that should enter multi-user in send-only mode. If a role is in both SendOnlyAssignment and</summary>
	public FGameplayTagContainer SendOnlyAssignment;
	///<summary>Hot reload of a level happens automatically when level / sublevel is changed. This property allows users</summary>
	public bool bShouldPromptForHotReloadOnLevel;
	///<summary>Client &amp; client session settings</summary>
	public FConcertClientSettings ClientSettings;
	///<summary>SourceControlSettings</summary>
	public FConcertSourceControlSettings SourceControlSettings;
	///<summary>Endpoint settings passed down to endpoints on creation</summary>
	public FConcertEndpointSettings EndpointSettings;
}
