#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AchievementBlueprintLibrary.h")]
///<summary>Library of synchronous achievement calls</summary>
public partial class UAchievementBlueprintLibrary : UBlueprintFunctionLibrary {
// AchievementBlueprintLibrary
	public void GetCachedAchievementProgress(UObject WorldContextObject,UObject PlayerController,string AchievementID,bool bFoundID,float Progress) {}
	public void GetCachedAchievementDescription(UObject WorldContextObject,UObject PlayerController,string AchievementID,bool bFoundID,string Title,string LockedDescription,string UnlockedDescription,bool bHidden) {}
}
