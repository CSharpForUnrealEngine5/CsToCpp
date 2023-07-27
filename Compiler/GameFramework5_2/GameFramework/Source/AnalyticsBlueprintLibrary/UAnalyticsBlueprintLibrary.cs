#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsBlueprintLibrary.h")]
public partial class UAnalyticsBlueprintLibrary : UBlueprintFunctionLibrary {
// AnalyticsBlueprintLibrary
	public static bool StartSession() { return default; }
	public static bool StartSessionWithAttributes(TArray<FAnalyticsEventAttr> Attributes) { return default; }
	public static void EndSession() {}
	public static void FlushEvents() {}
	public static void RecordEvent(string EventName) {}
	public static void RecordEventWithAttribute(string EventName,string AttributeName,string AttributeValue) {}
	public static void RecordEventWithAttributes(string EventName,TArray<FAnalyticsEventAttr> Attributes) {}
	public static void RecordItemPurchase(string ItemId,string Currency,int PerItemCost,int ItemQuantity) {}
	public static void RecordSimpleItemPurchase(string ItemId,int ItemQuantity) {}
	public static void RecordSimpleItemPurchaseWithAttributes(string ItemId,int ItemQuantity,TArray<FAnalyticsEventAttr> Attributes) {}
	public static void RecordSimpleCurrencyPurchase(string GameCurrencyType,int GameCurrencyAmount) {}
	public static void RecordSimpleCurrencyPurchaseWithAttributes(string GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	public static void RecordCurrencyPurchase(string GameCurrencyType,int GameCurrencyAmount,string RealCurrencyType,float RealMoneyCost,string PaymentProvider) {}
	public static void RecordCurrencyGiven(string GameCurrencyType,int GameCurrencyAmount) {}
	public static void RecordCurrencyGivenWithAttributes(string GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	public static FAnalyticsEventAttr MakeEventAttribute(string AttributeName,string AttributeValue) { return default; }
	public static string GetSessionId() { return default; }
	public static void SetSessionId(string SessionId) {}
	public static string GetUserId() { return default; }
	public static void SetUserId(string UserId) {}
	public static void SetAge(int Age) {}
	public static void SetLocation(string Location) {}
	public static void SetGender(string Gender) {}
	public static void SetBuildInfo(string BuildInfo) {}
	public static void RecordErrorWithAttributes(string Error,TArray<FAnalyticsEventAttr> Attributes) {}
	public static void RecordError(string Error) {}
	public static void RecordProgressWithFullHierarchyAndAttributes(string ProgressType,TArray<string> ProgressNames,TArray<FAnalyticsEventAttr> Attributes) {}
	public static void RecordProgressWithAttributes(string ProgressType,string ProgressName,TArray<FAnalyticsEventAttr> Attributes) {}
	public static void RecordProgress(string ProgressType,string ProgressName) {}
}
