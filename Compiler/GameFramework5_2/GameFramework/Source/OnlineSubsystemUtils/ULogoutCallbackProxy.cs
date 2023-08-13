namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogoutCallbackProxy.h")]
public partial class ULogoutCallbackProxy : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the logout completed successfully</summary>
	public FOnlineLogoutResult OnSuccess;
	///<summary>Called when the logout completed unsuccessfully</summary>
	public FOnlineLogoutResult OnFailure;
	///<summary>Logs out of the online service</summary>
	public static ULogoutCallbackProxy Logout(UObject WorldContextObject,APlayerController PlayerController) { return default; }
}
