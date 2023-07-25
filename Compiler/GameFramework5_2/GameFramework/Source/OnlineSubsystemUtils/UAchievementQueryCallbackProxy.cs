#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AchievementQueryCallbackProxy.h")]
public partial class UAchievementQueryCallbackProxy : UOnlineBlueprintCallProxyBase {
// AchievementQueryCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public UObject CacheAchievements(UObject WorldContextObject,UObject PlayerController) { return default; }
	public UObject CacheAchievementDescriptions(UObject WorldContextObject,UObject PlayerController) { return default; }
}
