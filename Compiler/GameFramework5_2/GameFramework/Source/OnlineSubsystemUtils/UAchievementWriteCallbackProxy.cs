#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AchievementWriteCallbackProxy.h")]
public partial class UAchievementWriteCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful achievement write</summary>
	public FAchievementWriteDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful achievement write</summary>
	public FAchievementWriteDelegate OnFailure;
	///<summary>Writes progress about an achievement to the default online subsystem</summary>
	public static UAchievementWriteCallbackProxy WriteAchievementProgress(UObject WorldContextObject,APlayerController PlayerController,string AchievementName,float Progress/*=100.0f*/,int UserTag/*=0*/) { return default; }
}
