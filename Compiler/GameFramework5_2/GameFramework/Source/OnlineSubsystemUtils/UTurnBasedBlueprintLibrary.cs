#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of synchronous achievement calls</summary>
[CppInclude("TurnBasedBlueprintLibrary.h")]
public partial class UTurnBasedBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>out</summary>
	public static void GetIsMyTurn(UObject WorldContextObject,APlayerController PlayerController,string MatchID,bool bIsMyTurn) {}
	///<summary>out</summary>
	public static void GetMyPlayerIndex(UObject WorldContextObject,APlayerController PlayerController,string MatchID,int PlayerIndex) {}
	///<summary>RegisterTurnBasedMatchInterfaceObject</summary>
	public static void RegisterTurnBasedMatchInterfaceObject(UObject WorldContextObject,APlayerController PlayerController,UObject Object) {}
	///<summary>out</summary>
	public static void GetPlayerDisplayName(UObject WorldContextObject,APlayerController PlayerController,string MatchID,int PlayerIndex,string PlayerDisplayName) {}
}
