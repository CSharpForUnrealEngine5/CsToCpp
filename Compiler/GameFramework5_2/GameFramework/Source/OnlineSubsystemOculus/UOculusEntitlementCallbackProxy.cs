namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes some of the Platform SDK for blueprint use.</summary>
[CppInclude("OculusEntitlementCallbackProxy.h")]
public partial class UOculusEntitlementCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful entitlement check</summary>
	public FOculusEntitlementCheckResult OnSuccess;
	///<summary>Called when there is an unsuccessful entitlement check</summary>
	public FOculusEntitlementCheckResult OnFailure;
	///<summary>Kick off entitlement check. Asynchronous-- see OnUserPrivilegeCompleteDelegate for results.</summary>
	public static UOculusEntitlementCallbackProxy VerifyEntitlement() { return default; }
}
