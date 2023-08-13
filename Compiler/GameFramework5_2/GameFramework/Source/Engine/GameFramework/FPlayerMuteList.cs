namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container responsible for managing the mute state of a player controller</summary>
[CppInclude("GameFramework/PlayerMuteList.h")]
public partial struct FPlayerMuteList {
	public bool bHasVoiceHandshakeCompleted;
	public int VoiceChannelIdx;
}
