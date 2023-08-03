#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseCallbackProxy2.h")]
public partial class UInAppPurchaseCallbackProxy2 : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful In-App Purchase transaction</summary>
	public FInAppPurchaseResult2 OnSuccess;
	///<summary>Called when there is an unsuccessful In-App Purchase transaction</summary>
	public FInAppPurchaseResult2 OnFailure;
	///<summary>Kicks off a transaction for the provided product identifier</summary>
	public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchase(APlayerController PlayerController,FInAppPurchaseProductRequest2 ProductRequest) { return default; }
	///<summary>CreateProxyObjectForInAppPurchaseUnprocessedPurchases</summary>
	public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseUnprocessedPurchases(APlayerController PlayerController) { return default; }
	///<summary>CreateProxyObjectForInAppPurchaseQueryOwned</summary>
	public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseQueryOwned(APlayerController PlayerController) { return default; }
}
