#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TurnBasedBlueprintLibrary.h")]
///<summary>Library of synchronous achievement calls</summary>
public partial class UTurnBasedBlueprintLibrary : UBlueprintFunctionLibrary {
// TurnBasedBlueprintLibrary
	public static void GetIsMyTurn(UObject WorldContextObject,APlayerController PlayerController,string MatchID,bool bIsMyTurn) {}
	public static void GetMyPlayerIndex(UObject WorldContextObject,APlayerController PlayerController,string MatchID,int PlayerIndex) {}
	public static void RegisterTurnBasedMatchInterfaceObject(UObject WorldContextObject,APlayerController PlayerController,UObject Object) {}
	public static void GetPlayerDisplayName(UObject WorldContextObject,APlayerController PlayerController,string MatchID,int PlayerIndex,string PlayerDisplayName) {}
}
