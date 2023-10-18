namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon host used for taking reservations for an existing game session</summary>
[CppInclude("LeaderboardBlueprintLibrary.h")]
public partial class ULeaderboardBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Writes an integer value to the specified leaderboard</summary>
	public static bool WriteLeaderboardInteger(APlayerController PlayerController,FName StatName,int StatValue) { return default; }
}
