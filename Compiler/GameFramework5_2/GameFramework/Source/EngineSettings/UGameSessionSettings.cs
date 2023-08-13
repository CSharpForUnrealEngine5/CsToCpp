namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameSessionSettings.h")]
public partial class UGameSessionSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Maximum number of spectators allowed by this server.</summary>
	public int MaxSpectators;
	///<summary>Maximum number of players allowed by this server.</summary>
	public int MaxPlayers;
	///<summary>Is voice enabled always or via a push to talk key binding.</summary>
	public bool bRequiresPushToTalk;
}
