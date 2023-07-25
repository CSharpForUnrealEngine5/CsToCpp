#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingPeerComponent.h")]
///<summary>A blueprint representation of a Pixel Streaming Peer Connection. Should communicate with a Pixel Streaming Signalling Connection</summary>
public partial class UPixelStreamingPeerComponent : UActorComponent {
// PixelStreamingPeerComponent
	public void SetConfig(FPixelStreamingRTCConfigWrapper Config) {}
	public FPixelStreamingSessionDescriptionWrapper CreateOffer() { return default; }
	public FPixelStreamingSessionDescriptionWrapper CreateAnswer(string Offer) { return default; }
	public void ReceiveAnswer(string Offer) {}
	public void ReceiveIceCandidate(FPixelStreamingIceCandidateWrapper Candidate) {}
	public FPixelStreamingOnIceCandidate OnIceCandidate;
	public FPixelStreamingOnIceConnection OnIceConnection;
	public FPixelStreamingOnIceDisconnection OnIceDisconnection;
	public UMediaPlayer VideoSinkPlayer;
}
