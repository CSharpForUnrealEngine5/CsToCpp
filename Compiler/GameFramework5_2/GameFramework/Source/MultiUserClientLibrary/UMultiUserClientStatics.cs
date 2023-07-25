#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUserClientStatics.h")]
public partial class UMultiUserClientStatics : UBlueprintFunctionLibrary {
// MultiUserClientStatics
	public void SetMultiUserPresenceEnabled(bool IsEnabled/*=true*/) {}
	public void SetMultiUserPresenceVisibility(string Name,bool Visibility,bool PropagateToAll/*=false*/) {}
	public void SetMultiUserPresenceVisibilityById(FGuid ClientEndpointId,bool Visibility,bool PropagateToAll/*=false*/) {}
	public FTransform GetMultiUserPresenceTransform(FGuid ClientEndpointId) { return default; }
	public void JumpToMultiUserPresence(string OtherUserName,FTransform TransformOffset) {}
	public void UpdateWorkspaceModifiedPackages() {}
	public void PersistMultiUserSessionChanges() {}
	public void PersistSpecifiedPackages(TArray<string> PackagesToPersist) {}
	public TArray<string> GatherSessionChanges(bool IgnorePersisted/*=true*/) { return default; }
	public UObject GetConcertSyncDatabase() { return default; }
	public FMultiUserClientInfo GetLocalMultiUserClientInfo() { return default; }
	public bool GetMultiUserClientInfoByName(string ClientName,FMultiUserClientInfo ClientInfo) { return default; }
	public bool GetRemoteMultiUserClientInfos(TArray<FMultiUserClientInfo> ClientInfos) { return default; }
	public bool ConfigureMultiUserClient(FMultiUserClientConfig ClientConfig) { return default; }
	public bool StartMultiUserDefaultConnection() { return default; }
	public FMultiUserConnectionError GetLastMultiUserConnectionError() { return default; }
	public EMultiUserConnectionStatus GetMultiUserConnectionStatusDetail() { return default; }
	public bool GetMultiUserConnectionStatus() { return default; }
}
