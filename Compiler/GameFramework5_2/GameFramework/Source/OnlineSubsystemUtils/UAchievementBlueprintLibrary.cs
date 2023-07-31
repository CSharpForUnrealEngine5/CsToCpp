#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of synchronous achievement calls</summary>
[CppInclude("AchievementBlueprintLibrary.h")]
public partial class UAchievementBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>out</summary>
	public static void GetCachedAchievementProgress(UObject WorldContextObject,APlayerController PlayerController,string AchievementID,bool bFoundID,float Progress) {}
	///<summary>out</summary>
	public static void GetCachedAchievementDescription(UObject WorldContextObject,APlayerController PlayerController,string AchievementID,bool bFoundID,string Title,string LockedDescription,string UnlockedDescription,bool bHidden) {}
}
