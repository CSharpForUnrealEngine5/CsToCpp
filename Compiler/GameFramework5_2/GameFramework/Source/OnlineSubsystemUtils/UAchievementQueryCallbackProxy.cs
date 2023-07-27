#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AchievementQueryCallbackProxy.h")]
public partial class UAchievementQueryCallbackProxy : UOnlineBlueprintCallProxyBase {
// AchievementQueryCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public static UAchievementQueryCallbackProxy CacheAchievements(UObject WorldContextObject,APlayerController PlayerController) { return default; }
	public static UAchievementQueryCallbackProxy CacheAchievementDescriptions(UObject WorldContextObject,APlayerController PlayerController) { return default; }
}
