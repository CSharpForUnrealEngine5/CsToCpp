#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsBlueprintLibrary.h")]
public partial class UAnalyticsBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>Starts an analytics session without any custom attributes specified</summary>
	public static bool StartSession() { return default; }
	///<summary>Starts an analytics session with custom attributes specified</summary>
	public static bool StartSessionWithAttributes(TArray<FAnalyticsEventAttr> Attributes) { return default; }
	///<summary>Ends an analytics session</summary>
	public static void EndSession() {}
	///<summary>Requests that any cached events be sent immediately</summary>
	public static void FlushEvents() {}
	///<summary>Records an event has happened by name without any attributes (an event counter)</summary>
	public static void RecordEvent(string EventName) {}
	///<summary>Records an event has happened by name with a single attribute</summary>
	public static void RecordEventWithAttribute(string EventName,string AttributeName,string AttributeValue) {}
	///<summary>Records an event has happened by name with a single attribute</summary>
	public static void RecordEventWithAttributes(string EventName,TArray<FAnalyticsEventAttr> Attributes) {}
	///<summary>Records an in-game item was purchased using the specified in-game currency</summary>
	public static void RecordItemPurchase(string ItemId,string Currency,int PerItemCost,int ItemQuantity) {}
	///<summary>Records an in-game item was purchased</summary>
	public static void RecordSimpleItemPurchase(string ItemId,int ItemQuantity) {}
	///<summary>Records an in-game item was purchased with attributes</summary>
	public static void RecordSimpleItemPurchaseWithAttributes(string ItemId,int ItemQuantity,TArray<FAnalyticsEventAttr> Attributes) {}
	///<summary>Records an in-game currency was purchased using real-world money</summary>
	public static void RecordSimpleCurrencyPurchase(string GameCurrencyType,int GameCurrencyAmount) {}
	///<summary>Records an in-game currency was purchased using real-world money</summary>
	public static void RecordSimpleCurrencyPurchaseWithAttributes(string GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	///<summary>Records an in-game currency was purchased using real-world money</summary>
	public static void RecordCurrencyPurchase(string GameCurrencyType,int GameCurrencyAmount,string RealCurrencyType,float RealMoneyCost,string PaymentProvider) {}
	///<summary>Records an in-game currency was granted by the game with no real-world money being involved</summary>
	public static void RecordCurrencyGiven(string GameCurrencyType,int GameCurrencyAmount) {}
	///<summary>Records an in-game currency was granted by the game with no real-world money being involved</summary>
	public static void RecordCurrencyGivenWithAttributes(string GameCurrencyType,int GameCurrencyAmount,TArray<FAnalyticsEventAttr> Attributes) {}
	///<summary>Builds a struct from the attribute name and value</summary>
	public static FAnalyticsEventAttr MakeEventAttribute(string AttributeName,string AttributeValue) { return default; }
	///<summary>Gets the current session id from the analytics provider</summary>
	public static string GetSessionId() { return default; }
	///<summary>Sets the session id (if supported) on the analytics provider</summary>
	public static void SetSessionId(string SessionId) {}
	///<summary>Gets the current user id from the analytics provider</summary>
	public static string GetUserId() { return default; }
	///<summary>Sets the user id (if supported) on the analytics provider</summary>
	public static void SetUserId(string UserId) {}
	///<summary>Sets the user&#39;s age (if supported) on the analytics provider</summary>
	public static void SetAge(int Age) {}
	///<summary>Sets the user&#39;s location (if supported) on the analytics provider</summary>
	public static void SetLocation(string Location) {}
	///<summary>Sets the user&#39;s gender (if supported) on the analytics provider</summary>
	public static void SetGender(string Gender) {}
	///<summary>Sets the game&#39;s build info (if supported) on the analytics provider</summary>
	public static void SetBuildInfo(string BuildInfo) {}
	///<summary>Records an error event has happened with attributes</summary>
	public static void RecordErrorWithAttributes(string Error,TArray<FAnalyticsEventAttr> Attributes) {}
	///<summary>Records an error event has happened</summary>
	public static void RecordError(string Error) {}
	///<summary>Records a user progress event has happened with a full list of progress hierarchy names and with attributes</summary>
	public static void RecordProgressWithFullHierarchyAndAttributes(string ProgressType,TArray<string> ProgressNames,TArray<FAnalyticsEventAttr> Attributes) {}
	///<summary>Records a user progress event has happened with attributes</summary>
	public static void RecordProgressWithAttributes(string ProgressType,string ProgressName,TArray<FAnalyticsEventAttr> Attributes) {}
	///<summary>Records a user progress event has happened</summary>
	public static void RecordProgress(string ProgressType,string ProgressName) {}
}
