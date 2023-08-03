#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AchievementQueryCallbackProxy.h")]
public partial class UAchievementQueryCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful query</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Fetches and caches achievement progress from the default online subsystem</summary>
	public static UAchievementQueryCallbackProxy CacheAchievements(UObject WorldContextObject,APlayerController PlayerController) { return default; }
	///<summary>Fetches and caches achievement descriptions from the default online subsystem</summary>
	public static UAchievementQueryCallbackProxy CacheAchievementDescriptions(UObject WorldContextObject,APlayerController PlayerController) { return default; }
}
