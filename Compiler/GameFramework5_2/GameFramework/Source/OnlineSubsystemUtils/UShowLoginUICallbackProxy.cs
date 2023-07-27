#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShowLoginUICallbackProxy.h")]
public partial class UShowLoginUICallbackProxy : UBlueprintAsyncActionBase {
// ShowLoginUICallbackProxy
	public FOnlineShowLoginUIResult OnSuccess;
	public FOnlineShowLoginUIResult OnFailure;
	public static UShowLoginUICallbackProxy ShowExternalLoginUI(UObject WorldContextObject,APlayerController InPlayerController) { return default; }
}
