#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameState is a subclass of GameStateBase that behaves like a multiplayer match-based game.</summary>
[CppInclude("GameFramework/GameState.h")]
public partial class AGameState : AGameStateBase {
	///<summary>What match state we are currently in</summary>
	public string MatchState;
	///<summary>Previous map state, used to handle if multiple transitions happen per frame</summary>
	public string PreviousMatchState;
	///<summary>Elapsed game time since match has started.</summary>
	public int ElapsedTime;
	///<summary>Match state has changed</summary>
	public  void OnRep_MatchState() {}
	///<summary>Gives clients the chance to do something when time gets updates</summary>
	public  void OnRep_ElapsedTime() {}
}
