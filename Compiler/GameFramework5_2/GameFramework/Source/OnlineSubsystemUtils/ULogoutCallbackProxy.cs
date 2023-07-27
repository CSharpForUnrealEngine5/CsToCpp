#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogoutCallbackProxy.h")]
public partial class ULogoutCallbackProxy : UBlueprintAsyncActionBase {
// LogoutCallbackProxy
	public FOnlineLogoutResult OnSuccess;
	public FOnlineLogoutResult OnFailure;
	public static ULogoutCallbackProxy Logout(UObject WorldContextObject,APlayerController PlayerController) { return default; }
}
