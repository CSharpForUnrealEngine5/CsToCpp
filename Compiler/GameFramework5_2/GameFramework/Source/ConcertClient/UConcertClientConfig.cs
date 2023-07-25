#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertClientSettings.h")]
public partial class UConcertClientConfig : UObject {
// ConcertClientConfig
	public bool bIsHeadless;
	public bool bInstallEditorToolbarButton;
	public bool bAutoConnect;
	public bool bRetryAutoConnectOnError;
	public EConcertServerType ServerType;
	public string DefaultServerURL;
	public string DefaultSessionName;
	public string DefaultSessionToRestore;
	public string DefaultSaveSessionAs;
	public FGameplayTagContainer ReadOnlyAssignment;
	public FGameplayTagContainer SendOnlyAssignment;
	public bool bShouldPromptForHotReloadOnLevel;
	public FConcertClientSettings ClientSettings;
	public FConcertSourceControlSettings SourceControlSettings;
	public FConcertEndpointSettings EndpointSettings;
}
