namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseCallbackProxy2.h")]
///<summary>State of a purchase transaction</summary>
public enum EInAppPurchaseStatus {
	Invalid=0,
	Failed=1,
	Deferred=2,
	Canceled=3,
	Purchased=4,
	Restored=5,
}
