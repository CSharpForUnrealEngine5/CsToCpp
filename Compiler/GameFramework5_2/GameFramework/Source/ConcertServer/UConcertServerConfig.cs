#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertServerSettings.h")]
public partial class UConcertServerConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, instruct the server to auto-archive sessions that were left in the working directory because the server did not exit properly rather than</summary>
	public bool bAutoArchiveOnReboot;
	///<summary>If true, instruct the server to auto-archive live sessions on shutdown.</summary>
	public bool bAutoArchiveOnShutdown;
	///<summary>Clean server sessions working directory when booting</summary>
	public bool bCleanWorkingDir;
	///<summary>Number of archived sessions to keep when booting, or &lt;0 to keep all archived sessions</summary>
	public int NumSessionsToKeep;
	///<summary>Name of the server, or empty to use the default name.</summary>
	public string ServerName;
	///<summary>Name of the default session created on the server.</summary>
	public string DefaultSessionName;
	///<summary>A set of keys identifying the clients that can discover and access the server. If empty, the server can be discovered and used by any clients.</summary>
	public TSet<string> AuthorizedClientKeys;
	///<summary>Name of the default session to restore on the server.</summary>
	public string DefaultSessionToRestore;
	///<summary>The version string for the default server created.</summary>
	public FConcertSessionVersionInfo DefaultVersionInfo;
	///<summary>Default server session settings</summary>
	public FConcertSessionSettings DefaultSessionSettings;
	///<summary>Server &amp; server session settings</summary>
	public FConcertServerSettings ServerSettings;
	///<summary>Endpoint settings passed down to endpoints on creation</summary>
	public FConcertEndpointSettings EndpointSettings;
	///<summary>The default directory where the server keeps the live session files. Can be specified on the server command line with `-CONCERTWORKINGDIR=`</summary>
	public string WorkingDir;
	///<summary>The default directory where the server keeps the archived session files. Can be specified on the server command line with `-CONCERTSAVEDDIR=`</summary>
	public string ArchiveDir;
	///<summary>The root directory where the server creates new session repositories (unless the client request specifies its own root). If empty or invalid, the server will use a default.</summary>
	public string SessionRepositoryRootDir;
	///<summary>If neither of WorkingDir and ArchiveDir are set, determine whether the server should mount a standard default session repository where new session will be created.</summary>
	public bool bMountDefaultSessionRepository;
}
