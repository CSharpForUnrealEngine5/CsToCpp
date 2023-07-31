#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Micro-transaction purchase information</summary>
[CppInclude("InAppPurchaseCallbackProxy2.h")]
public partial struct FInAppPurchaseProductInfo2 {
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
