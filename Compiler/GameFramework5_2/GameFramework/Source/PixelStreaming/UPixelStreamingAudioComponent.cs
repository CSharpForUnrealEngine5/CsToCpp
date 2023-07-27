#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingAudioComponent.h")]
///<summary>Allows in-engine playback of incoming WebRTC audio from a particular Pixel Streaming player/peer using their mic in the browser.</summary>
public partial class UPixelStreamingAudioComponent : USynthComponent {
// PixelStreamingAudioComponent
	public string StreamerToHear;
	public string PlayerToHear;
	public bool bAutoFindPeer;
	public  bool ListenTo(string PlayerToListenTo) { return default; }
	public  bool StreamerListenTo(string StreamerId,string PlayerToListenTo) { return default; }
	public  bool IsListeningToPlayer() { return default; }
	public  void Reset() {}
}
