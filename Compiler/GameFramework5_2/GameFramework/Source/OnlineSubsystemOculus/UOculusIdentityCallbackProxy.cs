#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusIdentityCallbackProxy.h")]
///<summary>Exposes the oculus id of the Platform SDK for blueprint use.</summary>
public partial class UOculusIdentityCallbackProxy : UOnlineBlueprintCallProxyBase {
// OculusIdentityCallbackProxy
	public FOculusIdentitySuccessResult OnSuccess;
	public FOculusIdentityFailureResult OnFailure;
	public static UOculusIdentityCallbackProxy GetOculusIdentity(int LocalUserNum) { return default; }
}
