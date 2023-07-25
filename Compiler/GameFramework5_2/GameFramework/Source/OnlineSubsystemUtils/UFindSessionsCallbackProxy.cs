#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FindSessionsCallbackProxy.h")]
public partial class UFindSessionsCallbackProxy : UOnlineBlueprintCallProxyBase {
// FindSessionsCallbackProxy
	public FBlueprintFindSessionsResultDelegate OnSuccess;
	public FBlueprintFindSessionsResultDelegate OnFailure;
	public UObject FindSessions(UObject WorldContextObject,UObject PlayerController,int MaxResults,bool bUseLAN) { return default; }
	public int GetPingInMs(FBlueprintSessionResult Result) { return default; }
	public string GetServerName(FBlueprintSessionResult Result) { return default; }
	public int GetCurrentPlayers(FBlueprintSessionResult Result) { return default; }
	public int GetMaxPlayers(FBlueprintSessionResult Result) { return default; }
}
