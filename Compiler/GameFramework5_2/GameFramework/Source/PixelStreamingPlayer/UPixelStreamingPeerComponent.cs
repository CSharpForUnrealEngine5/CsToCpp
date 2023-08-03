#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A blueprint representation of a Pixel Streaming Peer Connection. Should communicate with a Pixel Streaming Signalling Connection</summary>
[CppInclude("PixelStreamingPeerComponent.h")]
public partial class UPixelStreamingPeerComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the RTC Configuration for this Peer Connection.</summary>
	public  void SetConfig(FPixelStreamingRTCConfigWrapper Config) {}
	///<summary>Creates an offer.</summary>
	public  FPixelStreamingSessionDescriptionWrapper CreateOffer() { return default; }
	///<summary>Creates an answer to the given offer objet that was provided.</summary>
	public  FPixelStreamingSessionDescriptionWrapper CreateAnswer(string Offer) { return default; }
	///<summary>Receives an answer from a streamer after we&#39;ve sent an offer to receive.</summary>
	public  void ReceiveAnswer(string Offer) {}
	///<summary>Notify the peer connection of an ICE candidate sent by the singalling connection.</summary>
	public  void ReceiveIceCandidate(FPixelStreamingIceCandidateWrapper Candidate) {}
	///<summary>Once negotiation is completed the Peer Connection can generate Ice Candidate objects. These need to be sent to a signalling server to allow proper connection.</summary>
	public FPixelStreamingOnIceCandidate OnIceCandidate;
	///<summary>Once a connection has been connected and streaming should be available.</summary>
	public FPixelStreamingOnIceConnection OnIceConnection;
	///<summary>When an ice connection is lost.</summary>
	public FPixelStreamingOnIceDisconnection OnIceDisconnection;
	///<summary>A sink for the video data received once this connection has finished negotiating.</summary>
	public UMediaPlayer VideoSinkPlayer;
}
