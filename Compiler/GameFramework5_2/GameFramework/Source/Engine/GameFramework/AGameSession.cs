#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameSession.h")]
///<summary>Acts as a game-specific wrapper around the session interface. The game code makes calls to this when it needs to interact with the session interface.</summary>
public partial class AGameSession : AInfo {
// GameSession
	public int MaxSpectators;
	public int MaxPlayers;
	public int MaxPartySize;
	public byte MaxSplitscreensPerConnection;
	public bool bRequiresPushToTalk;
	public string SessionName;
}
