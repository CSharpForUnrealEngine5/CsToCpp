#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes FindSession of the Platform SDK for blueprint use.</summary>
[CppInclude("OculusFindSessionsCallbackProxy.h")]
public partial class UOculusFindSessionsCallbackProxy : UOnlineBlueprintCallProxyBase {
	///<summary>Called when there is a successful query</summary>
	public FBlueprintFindSessionsResultDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FBlueprintFindSessionsResultDelegate OnFailure;
	///<summary>Searches for matchmaking room sessions with the oculus online subsystem</summary>
	public static UOculusFindSessionsCallbackProxy FindMatchmakingSessions(int MaxResults,string OculusMatchmakingPool) { return default; }
	///<summary>Searches for moderated room sessions with the oculus online subsystem</summary>
	public static UOculusFindSessionsCallbackProxy FindModeratedSessions(int MaxResults) { return default; }
}
