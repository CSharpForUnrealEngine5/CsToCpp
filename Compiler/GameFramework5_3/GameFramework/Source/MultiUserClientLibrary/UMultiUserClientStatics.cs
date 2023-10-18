namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUserClientStatics.h")]
public partial class UMultiUserClientStatics : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set whether presence is currently enabled and should be shown (unless hidden by other settings)</summary>
	public static void SetMultiUserPresenceEnabled(bool IsEnabled/*=true*/) {}
	///<summary>Set Presence Actor Visibility by display name</summary>
	public static void SetMultiUserPresenceVisibility(string Name,bool Visibility,bool PropagateToAll/*=false*/) {}
	///<summary>Set Presence Actor Visibility by client id</summary>
	public static void SetMultiUserPresenceVisibilityById(FGuid ClientEndpointId,bool Visibility,bool PropagateToAll/*=false*/) {}
	///<summary>Get the Presence Actor transform for the specified client endpoint id or identity if the client isn&#39;t found</summary>
	public static FTransform GetMultiUserPresenceTransform(FGuid ClientEndpointId) { return default; }
	///<summary>Teleport to another Multi-User user&#39;s presence.</summary>
	public static void JumpToMultiUserPresence(string OtherUserName,FTransform TransformOffset) {}
	///<summary>Update Multi-User Workspace Modified Packages to be in sync for source control submission.</summary>
	public static void UpdateWorkspaceModifiedPackages() {}
	///<summary>Persist the session changes and prepare the files for source control submission.</summary>
	public static void PersistMultiUserSessionChanges() {}
	///<summary>Persist the specified sessions changes using source control.</summary>
	public static void PersistSpecifiedPackages(TArray<FName> PackagesToPersist) {}
	///<summary>Get the list of packages that have changed since the last persist unless ignore persisted is false.</summary>
	public static TArray<FName> GatherSessionChanges(bool IgnorePersisted/*=true*/) { return default; }
	///<summary>Get the proxy object for the sync database.</summary>
	public static UMultiUserClientSyncDatabase GetConcertSyncDatabase() { return default; }
	///<summary>Get the local ClientInfo. Works when not connected to a session.</summary>
	public static FMultiUserClientInfo GetLocalMultiUserClientInfo() { return default; }
	///<summary>Get the current SessionInfo. Works when not connected to a session, but returns an empty session info.</summary>
	public static FMultiUserSessionInfo GetMultiUserSessionInfo() { return default; }
	///<summary>Get the ClientInfo for any Multi-User participant by name. The local user is found even when not connected to a session. Returns false is no client was found.</summary>
	public static bool GetMultiUserClientInfoByName(string ClientName,FMultiUserClientInfo ClientInfo) { return default; }
	///<summary>Get ClientInfos of current Multi-User participants except for the local user. Returns false is no remote clients were found.</summary>
	public static bool GetRemoteMultiUserClientInfos(TArray<FMultiUserClientInfo> ClientInfos) { return default; }
	///<summary>Configure the Multi-User client.</summary>
	public static bool ConfigureMultiUserClient(FMultiUserClientConfig ClientConfig) { return default; }
	///<summary>Start the Multi-User default connection process.</summary>
	public static bool StartMultiUserDefaultConnection() { return default; }
	///<summary>Get the last Multi-User connection error that happened, if any</summary>
	public static FMultiUserConnectionError GetLastMultiUserConnectionError() { return default; }
	///<summary>Get Multi-User connection status.</summary>
	public static EMultiUserConnectionStatus GetMultiUserConnectionStatusDetail() { return default; }
	///<summary>Get Multi-User connection status.</summary>
	public static bool GetMultiUserConnectionStatus() { return default; }
}
