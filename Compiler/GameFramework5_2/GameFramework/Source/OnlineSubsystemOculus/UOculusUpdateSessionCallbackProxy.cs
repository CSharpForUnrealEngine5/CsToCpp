#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes UpdateSession of the Platform SDK for blueprint use.</summary>
[CppInclude("OculusUpdateSessionCallbackProxy.h")]
public partial class UOculusUpdateSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
	///<summary>Called when the session was updated successfully</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there was an error updating the session</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Kick off UpdateSession check. Asynchronous-- see OnUpdateCompleteDelegate for results.</summary>
	public static UOculusUpdateSessionCallbackProxy SetSessionEnqueue(bool bShouldEnqueueInMatchmakingPool) { return default; }
}
