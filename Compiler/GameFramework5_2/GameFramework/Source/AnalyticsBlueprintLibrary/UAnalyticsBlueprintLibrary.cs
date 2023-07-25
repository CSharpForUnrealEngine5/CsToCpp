#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsBlueprintLibrary.h")]
public partial class UAnalyticsBlueprintLibrary : UBlueprintFunctionLibrary {
// AnalyticsBlueprintLibrary
	public bool StartSession() { return default; }
	public bool StartSessionWithAttributes(TArray<FAnalyticsEventAttr> Attributes) { return default; }
	public void EndSession() {}
	public void FlushEvents() {}
	public void RecordEvent(string EventName) {}
	public void RecordEventWithAttribute(string EventName,string AttributeName,string AttributeValue) {}
	public void RecordEventWithAttributes(string EventName,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordItemPurchase(string ItemId,string Currency,int PerItemCost,int ItemQuantity) {}
	public void RecordSimpleItemPurchase(string ItemId,int ItemQuantity) {}
	public void RecordSimpleItemPurchaseWithAttributes(string ItemId,int ItemQuantity,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordSimpleCurrencyPurchase(string GameCurrencyType,int GameCurrencyAmount) {}
	public void RecordSimpleCurrencyPurchaseWithAttributes(string GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordCurrencyPurchase(string GameCurrencyType,int GameCurrencyAmount,string RealCurrencyType,float RealMoneyCost,string PaymentProvider) {}
	public void RecordCurrencyGiven(string GameCurrencyType,int GameCurrencyAmount) {}
	public void RecordCurrencyGivenWithAttributes(string GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	public FAnalyticsEventAttr MakeEventAttribute(string AttributeName,string AttributeValue) { return default; }
	public string GetSessionId() { return default; }
	public void SetSessionId(string SessionId) {}
	public string GetUserId() { return default; }
	public void SetUserId(string UserId) {}
	public void SetAge(int Age) {}
	public void SetLocation(string Location) {}
	public void SetGender(string Gender) {}
	public void SetBuildInfo(string BuildInfo) {}
	public void RecordErrorWithAttributes(string Error,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordError(string Error) {}
	public void RecordProgressWithFullHierarchyAndAttributes(string ProgressType,TArray<string> ProgressNames,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordProgressWithAttributes(string ProgressType,string ProgressName,TArray<FAnalyticsEventAttr> Attributes) {}
	public void RecordProgress(string ProgressType,string ProgressName) {}
}
