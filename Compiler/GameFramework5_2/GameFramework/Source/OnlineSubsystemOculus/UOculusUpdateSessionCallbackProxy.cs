#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusUpdateSessionCallbackProxy.h")]
///<summary>Exposes UpdateSession of the Platform SDK for blueprint use.</summary>
public partial class UOculusUpdateSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
// OculusUpdateSessionCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public UObject SetSessionEnqueue(bool bShouldEnqueueInMatchmakingPool) { return default; }
}
