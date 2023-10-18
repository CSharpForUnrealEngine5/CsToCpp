namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseCheckoutCallbackProxy.h")]
public partial class UInAppPurchaseCheckoutCallbackProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful In-App Purchase transaction</summary>
	public FOnlineProxyInAppCheckoutResult OnSuccess;
	///<summary>Called when there is an unsuccessful In-App Purchase transaction</summary>
	public FOnlineProxyInAppCheckoutResult OnFailure;
	///<summary>Kicks off a transaction for the provided product identifier</summary>
	public static UInAppPurchaseCheckoutCallbackProxy CreateProxyObjectForInAppPurchaseCheckout(APlayerController PlayerController,FInAppPurchaseProductRequest2 ProductRequest) { return default; }
}
