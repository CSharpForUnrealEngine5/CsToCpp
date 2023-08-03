#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes the oculus id of the Platform SDK for blueprint use.</summary>
[CppInclude("OculusIdentityCallbackProxy.h")]
public partial class UOculusIdentityCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when it successfully gets back the oculus id</summary>
	public FOculusIdentitySuccessResult OnSuccess;
	///<summary>Called when it fails to get the oculus id</summary>
	public FOculusIdentityFailureResult OnFailure;
	///<summary>Kick off GetOculusIdentity. Asynchronous-- see OnLoginCompleteDelegate for results.</summary>
	public static UOculusIdentityCallbackProxy GetOculusIdentity(int LocalUserNum) { return default; }
}
