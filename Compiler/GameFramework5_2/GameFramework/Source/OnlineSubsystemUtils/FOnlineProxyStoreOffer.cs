#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseQueryCallbackProxy2.h")]
///<summary>Offer entry for display from online store</summary>
public partial struct FOnlineProxyStoreOffer {
// OnlineProxyStoreOffer
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
