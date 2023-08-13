namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of synchronous achievement calls</summary>
[CppInclude("AchievementBlueprintLibrary.h")]
public partial class UAchievementBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>out</summary>
	public static void GetCachedAchievementProgress(UObject WorldContextObject,APlayerController PlayerController,string AchievementID,bool bFoundID,float Progress) {}
	///<summary>out</summary>
	public static void GetCachedAchievementDescription(UObject WorldContextObject,APlayerController PlayerController,string AchievementID,bool bFoundID,FText Title,FText LockedDescription,FText UnlockedDescription,bool bHidden) {}
}
