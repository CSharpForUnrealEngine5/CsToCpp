#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseQueryCallbackProxy2.h")]
public partial class UInAppPurchaseQueryCallbackProxy2 : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful InAppPurchase query</summary>
	public FInAppPurchaseQuery2Result OnSuccess;
	///<summary>Called when there is an unsuccessful InAppPurchase query</summary>
	public FInAppPurchaseQuery2Result OnFailure;
	///<summary>Queries a InAppPurchase for an integer value</summary>
	public static UInAppPurchaseQueryCallbackProxy2 CreateProxyObjectForInAppPurchaseQuery(APlayerController PlayerController,TArray<string> ProductIdentifiers) { return default; }
}
