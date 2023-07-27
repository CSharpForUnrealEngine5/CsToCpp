#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUserClientStatics.h")]
public partial class UMultiUserClientStatics : UBlueprintFunctionLibrary {
// MultiUserClientStatics
	public static void SetMultiUserPresenceEnabled(bool IsEnabled/*=true*/) {}
	public static void SetMultiUserPresenceVisibility(string Name,bool Visibility,bool PropagateToAll/*=false*/) {}
	public static void SetMultiUserPresenceVisibilityById(FGuid ClientEndpointId,bool Visibility,bool PropagateToAll/*=false*/) {}
	public static FTransform GetMultiUserPresenceTransform(FGuid ClientEndpointId) { return default; }
	public static void JumpToMultiUserPresence(string OtherUserName,FTransform TransformOffset) {}
	public static void UpdateWorkspaceModifiedPackages() {}
	public static void PersistMultiUserSessionChanges() {}
	public static void PersistSpecifiedPackages(TArray<string> PackagesToPersist) {}
	public static TArray<string> GatherSessionChanges(bool IgnorePersisted/*=true*/) { return default; }
	public static UMultiUserClientSyncDatabase GetConcertSyncDatabase() { return default; }
	public static FMultiUserClientInfo GetLocalMultiUserClientInfo() { return default; }
	public static bool GetMultiUserClientInfoByName(string ClientName,FMultiUserClientInfo ClientInfo) { return default; }
	public static bool GetRemoteMultiUserClientInfos(TArray<FMultiUserClientInfo> ClientInfos) { return default; }
	public static bool ConfigureMultiUserClient(FMultiUserClientConfig ClientConfig) { return default; }
	public static bool StartMultiUserDefaultConnection() { return default; }
	public static FMultiUserConnectionError GetLastMultiUserConnectionError() { return default; }
	public static EMultiUserConnectionStatus GetMultiUserConnectionStatusDetail() { return default; }
	public static bool GetMultiUserConnectionStatus() { return default; }
}
