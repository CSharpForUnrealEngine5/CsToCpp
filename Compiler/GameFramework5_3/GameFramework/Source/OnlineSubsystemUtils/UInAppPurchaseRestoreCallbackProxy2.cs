namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseRestoreCallbackProxy2.h")]
public partial class UInAppPurchaseRestoreCallbackProxy2 : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful In-App Purchase transaction</summary>
	public FInAppPurchaseRestoreResult2 OnSuccess;
	///<summary>Called when there is an unsuccessful In-App Purchase transaction</summary>
	public FInAppPurchaseRestoreResult2 OnFailure;
	///<summary>Kicks off a transaction for the provided product identifier</summary>
	public static UInAppPurchaseRestoreCallbackProxy2 CreateProxyObjectForInAppPurchaseRestore(TArray<FInAppPurchaseProductRequest2> ConsumableProductFlags,APlayerController PlayerController) { return default; }
}
