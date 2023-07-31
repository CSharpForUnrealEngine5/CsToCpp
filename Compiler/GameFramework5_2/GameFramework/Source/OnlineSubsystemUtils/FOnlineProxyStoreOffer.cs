#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Offer entry for display from online store</summary>
[CppInclude("InAppPurchaseQueryCallbackProxy2.h")]
public partial struct FOnlineProxyStoreOffer {
	public string OfferId;
	public string Title;
	public string Description;
	public string LongDescription;
	public string RegularPriceText;
	public int RegularPrice;
	public string PriceText;
	public int NumericPrice;
	public string CurrencyCode;
	public FDateTime ReleaseDate;
	public FDateTime ExpirationDate;
	public EOnlineProxyStoreOfferDiscountType DiscountType;
	public TMap<string,string> DynamicFields;
}
