namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseReceiptsCallbackProxy.h")]
public partial class UInAppPurchaseReceiptsCallbackProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful In-App Purchase transaction</summary>
	public FOnlineProxyInAppReceiptsResult OnSuccess;
	///<summary>Called when there is an unsuccessful In-App Purchase transaction</summary>
	public FOnlineProxyInAppReceiptsResult OnFailure;
	///<summary>CreateProxyObjectForInAppPurchaseGetKnownReceipts</summary>
	public static UInAppPurchaseReceiptsCallbackProxy CreateProxyObjectForInAppPurchaseGetKnownReceipts(APlayerController PlayerController) { return default; }
	///<summary>CreateProxyObjectForInAppPurchaseQueryOwnedProducts</summary>
	public static UInAppPurchaseReceiptsCallbackProxy CreateProxyObjectForInAppPurchaseQueryOwnedProducts(APlayerController PlayerController) { return default; }
	///<summary>CreateProxyObjectForInAppPurchaseRestoreOwnedProducts</summary>
	public static UInAppPurchaseReceiptsCallbackProxy CreateProxyObjectForInAppPurchaseRestoreOwnedProducts(APlayerController PlayerController) { return default; }
}
