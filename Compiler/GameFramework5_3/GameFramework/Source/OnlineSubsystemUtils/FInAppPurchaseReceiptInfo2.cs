namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Micro-transaction purchase information</summary>
[CppInclude("InAppPurchaseDataTypes.h")]
public partial struct FInAppPurchaseReceiptInfo2 {
	public string ItemName;
	public string ItemId;
	public string ValidationInfo;
	public string TransactionIdentifier;
}
