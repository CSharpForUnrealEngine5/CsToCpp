namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/VoiceConfig.h")]
public partial class UVOIPTalker : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>function for creating and registering a UVOIPTalker.</summary>
	public static UVOIPTalker CreateTalkerForPlayer(APlayerState OwningState) { return default; }
	///<summary>This function sets up this talker with a specific player.</summary>
	public void RegisterWithPlayerState(APlayerState OwningState) {}
	///<summary>Get the current level of how loud this player is speaking. Will return 0.0</summary>
	public float GetVoiceLevel() { return default; }
	///<summary>Blueprint native event for when this player starts speaking.</summary>
	public void BPOnTalkingBegin(UAudioComponent AudioComponent) {}
	///<summary>Blueprint native event for when this player stops speaking.</summary>
	public void BPOnTalkingEnd() {}
	///<summary>Configurable settings for this player&#39;s voice. When set, this will update the next time the player speaks.</summary>
	public FVoiceSettings Settings;
}
