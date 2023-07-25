#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Interfaces/OnlineStoreInterfaceV2.h")]
///<summary>Possible result states of an in-app purchase transaction</summary>
[CppEnumInNamespace]
public enum EInAppPurchaseState {
	Unknown=0,
	Success=1,
	Failed=2,
	Cancelled=3,
	Invalid=4,
	NotAllowed=5,
	Restored=6,
	AlreadyOwned=7,
}
