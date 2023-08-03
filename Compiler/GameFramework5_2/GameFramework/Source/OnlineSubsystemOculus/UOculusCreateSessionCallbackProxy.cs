#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes CreateSession of the Platform SDK for blueprint use.</summary>
[CppInclude("OculusCreateSessionCallbackProxy.h")]
public partial class UOculusCreateSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the session was created successfully</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there was an error creating the session</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Kick off CreateSession check. Asynchronous-- see OnCreateSessionCompleteDelegate for results.</summary>
	public static UOculusCreateSessionCallbackProxy CreateSession(int PublicConnections,string OculusMatchmakingPool) { return default; }
}
