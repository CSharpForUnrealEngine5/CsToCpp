namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows in-engine playback of incoming WebRTC audio from a particular Pixel Streaming player/peer using their mic in the browser.</summary>
[CppInclude("PixelStreamingAudioComponent.h")]
public partial class UPixelStreamingAudioComponent : USynthComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The Pixel Streaming streamer of the player that we wish to listen to.</summary>
	public string StreamerToHear;
	///<summary>The Pixel Streaming player/peer whose audio we wish to listen to.</summary>
	public string PlayerToHear;
	///<summary>If not already listening to a player/peer will try to attach for listening to the &quot;PlayerToHear&quot; each tick.</summary>
	public bool bAutoFindPeer;
	///<summary>Listen to a specific player on the default streamer. If the player is not found this component will be silent.</summary>
	public bool ListenTo(string PlayerToListenTo) { return default; }
	///<summary>Listen to a specific player. If the player is not found this component will be silent.</summary>
	public bool StreamerListenTo(string StreamerId,string PlayerToListenTo) { return default; }
	///<summary>True if listening to a connected WebRTC peer through Pixel Streaming.</summary>
	public bool IsListeningToPlayer() { return default; }
	///<summary>Stops listening to any connected player/peer and resets internal state so component is ready to listen again.</summary>
	public void Reset() {}
}
