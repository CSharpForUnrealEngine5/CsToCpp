#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusEntitlementCallbackProxy.h")]
///<summary>Exposes some of the Platform SDK for blueprint use.</summary>
public partial class UOculusEntitlementCallbackProxy : UOnlineBlueprintCallProxyBase {
// OculusEntitlementCallbackProxy
	public FOculusEntitlementCheckResult OnSuccess;
	public FOculusEntitlementCheckResult OnFailure;
	public UObject VerifyEntitlement() { return default; }
}
