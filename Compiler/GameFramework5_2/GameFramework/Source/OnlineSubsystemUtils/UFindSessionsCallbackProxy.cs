#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FindSessionsCallbackProxy.h")]
public partial class UFindSessionsCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful query</summary>
	public FBlueprintFindSessionsResultDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FBlueprintFindSessionsResultDelegate OnFailure;
	///<summary>Searches for advertised sessions with the default online subsystem</summary>
	public static UFindSessionsCallbackProxy FindSessions(UObject WorldContextObject,APlayerController PlayerController,int MaxResults,bool bUseLAN) { return default; }
	///<summary>GetPingInMs</summary>
	public static int GetPingInMs(FBlueprintSessionResult Result) { return default; }
	///<summary>GetServerName</summary>
	public static string GetServerName(FBlueprintSessionResult Result) { return default; }
	///<summary>GetCurrentPlayers</summary>
	public static int GetCurrentPlayers(FBlueprintSessionResult Result) { return default; }
	///<summary>GetMaxPlayers</summary>
	public static int GetMaxPlayers(FBlueprintSessionResult Result) { return default; }
}
