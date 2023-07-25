#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TurnBasedBlueprintLibrary.h")]
///<summary>Library of synchronous achievement calls</summary>
public partial class UTurnBasedBlueprintLibrary : UBlueprintFunctionLibrary {
// TurnBasedBlueprintLibrary
	public void GetIsMyTurn(UObject WorldContextObject,UObject PlayerController,string MatchID,bool bIsMyTurn) {}
	public void GetMyPlayerIndex(UObject WorldContextObject,UObject PlayerController,string MatchID,int PlayerIndex) {}
	public void RegisterTurnBasedMatchInterfaceObject(UObject WorldContextObject,UObject PlayerController,UObject Object) {}
	public void GetPlayerDisplayName(UObject WorldContextObject,UObject PlayerController,string MatchID,int PlayerIndex,string PlayerDisplayName) {}
}
