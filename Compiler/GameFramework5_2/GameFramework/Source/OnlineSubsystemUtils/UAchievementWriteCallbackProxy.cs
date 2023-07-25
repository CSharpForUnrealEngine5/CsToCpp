#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AchievementWriteCallbackProxy.h")]
public partial class UAchievementWriteCallbackProxy : UOnlineBlueprintCallProxyBase {
// AchievementWriteCallbackProxy
	public FAchievementWriteDelegate OnSuccess;
	public FAchievementWriteDelegate OnFailure;
	public UObject WriteAchievementProgress(UObject WorldContextObject,UObject PlayerController,string AchievementName,float Progress/*=100.0f*/,int UserTag/*=0*/) { return default; }
}
