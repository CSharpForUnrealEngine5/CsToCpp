#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertServerSettings.h")]
public partial class UConcertServerConfig : UObject {
// ConcertServerConfig
	public bool bAutoArchiveOnReboot;
	public bool bAutoArchiveOnShutdown;
	public bool bCleanWorkingDir;
	public int NumSessionsToKeep;
	public string ServerName;
	public string DefaultSessionName;
	public TSet<string> AuthorizedClientKeys;
	public string DefaultSessionToRestore;
	public FConcertSessionVersionInfo DefaultVersionInfo;
	public FConcertSessionSettings DefaultSessionSettings;
	public FConcertServerSettings ServerSettings;
	public FConcertEndpointSettings EndpointSettings;
	public string WorkingDir;
	public string ArchiveDir;
	public string SessionRepositoryRootDir;
	public bool bMountDefaultSessionRepository;
}
