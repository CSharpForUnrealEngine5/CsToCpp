#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusCreateSessionCallbackProxy.h")]
///<summary>Exposes CreateSession of the Platform SDK for blueprint use.</summary>
public partial class UOculusCreateSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
// OculusCreateSessionCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public UObject CreateSession(int PublicConnections,string OculusMatchmakingPool) { return default; }
}
