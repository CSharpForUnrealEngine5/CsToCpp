#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/EngineMessage.h")]
public partial class UEngineMessage : ULocalMessage {
	///<summary>Message displayed in message dialog when player pawn fails to spawn because no playerstart was available.</summary>
	public string FailedPlaceMessage;
	///<summary>Message when player join attempt is refused because the server is at capacity.</summary>
	public string MaxedOutMessage;
	///<summary>Message when a new player enters the game.</summary>
	public string EnteredMessage;
	///<summary>Message when a player leaves the game.</summary>
	public string LeftMessage;
	///<summary>Message when a player changes their name.</summary>
	public string GlobalNameChange;
	///<summary>Message when a new spectator enters the server (if spectator has a player name).</summary>
	public string SpecEnteredMessage;
	///<summary>Message when a new player enters the server (if player is unnamed).</summary>
	public string NewPlayerMessage;
	///<summary>Message when a new spectator enters the server (if spectator is unnamed).</summary>
	public string NewSpecMessage;
}
