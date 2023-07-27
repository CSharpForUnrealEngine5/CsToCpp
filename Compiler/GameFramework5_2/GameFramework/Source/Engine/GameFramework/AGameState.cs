#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameState.h")]
///<summary>GameState is a subclass of GameStateBase that behaves like a multiplayer match-based game.</summary>
public partial class AGameState : AGameStateBase {
// GameState
	public string MatchState;
	public string PreviousMatchState;
	public int ElapsedTime;
	public  void OnRep_MatchState() {}
	public  void OnRep_ElapsedTime() {}
}
