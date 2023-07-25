#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFindSessionsCallbackProxy.h")]
///<summary>Exposes FindSession of the Platform SDK for blueprint use.</summary>
public partial class UOculusFindSessionsCallbackProxy : UOnlineBlueprintCallProxyBase {
// OculusFindSessionsCallbackProxy
	public FBlueprintFindSessionsResultDelegate OnSuccess;
	public FBlueprintFindSessionsResultDelegate OnFailure;
	public UObject FindMatchmakingSessions(int MaxResults,string OculusMatchmakingPool) { return default; }
	public UObject FindModeratedSessions(int MaxResults) { return default; }
}
