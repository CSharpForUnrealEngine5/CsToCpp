#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseCallbackProxy2.h")]
public partial class UInAppPurchaseCallbackProxy2 : UObject {
// InAppPurchaseCallbackProxy2
	public FInAppPurchaseResult2 OnSuccess;
	public FInAppPurchaseResult2 OnFailure;
	public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchase(APlayerController PlayerController,FInAppPurchaseProductRequest2 ProductRequest) { return default; }
	public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseUnprocessedPurchases(APlayerController PlayerController) { return default; }
	public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseQueryOwned(APlayerController PlayerController) { return default; }
}
