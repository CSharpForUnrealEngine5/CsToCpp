namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Offer entry for display from online store</summary>
[CppInclude("InAppPurchaseQueryCallbackProxy2.h")]
public partial struct FOnlineProxyStoreOffer {
	public string OfferId;
	public FText Title;
	public FText Description;
	public FText LongDescription;
	public FText RegularPriceText;
	public int RegularPrice;
	public FText PriceText;
	public int NumericPrice;
	public string CurrencyCode;
	public FDateTime ReleaseDate;
	public FDateTime ExpirationDate;
	public EOnlineProxyStoreOfferDiscountType DiscountType;
	public TMap<string,string> DynamicFields;
}
