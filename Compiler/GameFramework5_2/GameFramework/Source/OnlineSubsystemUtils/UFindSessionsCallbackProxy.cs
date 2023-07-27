#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FindSessionsCallbackProxy.h")]
public partial class UFindSessionsCallbackProxy : UOnlineBlueprintCallProxyBase {
// FindSessionsCallbackProxy
	public FBlueprintFindSessionsResultDelegate OnSuccess;
	public FBlueprintFindSessionsResultDelegate OnFailure;
	public static UFindSessionsCallbackProxy FindSessions(UObject WorldContextObject,APlayerController PlayerController,int MaxResults,bool bUseLAN) { return default; }
	public static int GetPingInMs(FBlueprintSessionResult Result) { return default; }
	public static string GetServerName(FBlueprintSessionResult Result) { return default; }
	public static int GetCurrentPlayers(FBlueprintSessionResult Result) { return default; }
	public static int GetMaxPlayers(FBlueprintSessionResult Result) { return default; }
}
