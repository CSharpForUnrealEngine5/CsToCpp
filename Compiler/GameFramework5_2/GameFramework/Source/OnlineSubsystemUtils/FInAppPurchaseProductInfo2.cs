#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseCallbackProxy2.h")]
///<summary>Micro-transaction purchase information</summary>
public partial struct FInAppPurchaseProductInfo2 {
// InAppPurchaseProductInfo2
	public string Identifier;
	public string TransactionIdentifier;
	public string DisplayName;
	public string DisplayDescription;
	public string DisplayPrice;
	public float RawPrice;
	public string CurrencyCode;
	public string CurrencySymbol;
	public string DecimalSeparator;
	public string GroupingSeparator;
	public string ReceiptData;
	public TMap<string,string> DynamicFields;
}
