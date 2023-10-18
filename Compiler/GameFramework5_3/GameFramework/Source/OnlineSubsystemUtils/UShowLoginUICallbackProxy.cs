namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShowLoginUICallbackProxy.h")]
public partial class UShowLoginUICallbackProxy : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful query</summary>
	public FOnlineShowLoginUIResult OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FOnlineShowLoginUIResult OnFailure;
	///<summary>Shows the login UI for the currently active online subsystem, if the subsystem supports a login UI.</summary>
	public static UShowLoginUICallbackProxy ShowExternalLoginUI(UObject WorldContextObject,APlayerController InPlayerController) { return default; }
}
