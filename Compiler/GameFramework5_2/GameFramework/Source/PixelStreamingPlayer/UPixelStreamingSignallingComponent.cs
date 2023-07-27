#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingSignallingComponent.h")]
///<summary>A blueprint class representing a Pixel Streaming Signalling connection. Used to communicate with the signalling server and</summary>
public partial class UPixelStreamingSignallingComponent : UActorComponent {
// PixelStreamingSignallingComponent
	public  void Connect(string Url) {}
	public  void Disconnect() {}
	public  void SendOffer(FPixelStreamingSessionDescriptionWrapper Offer) {}
	public  void SendAnswer(FPixelStreamingSessionDescriptionWrapper Answer) {}
	public  void SendIceCandidate(FPixelStreamingIceCandidateWrapper CandidateWrapper) {}
	public FPixelStreamingSignallingComponentConnected OnConnected;
	public FPixelStreamingSignallingComponentConnectionError OnConnectionError;
	public FPixelStreamingSignallingComponentDisconnected OnDisconnected;
	public FPixelStreamingSignallingComponentConfig OnConfig;
	public FPixelStreamingSignallingComponentOffer OnOffer;
	public FPixelStreamingSignallingComponentAnswer OnAnswer;
	public FPixelStreamingSignallingComponentIceCandidate OnIceCandidate;
	public UStreamMediaSource MediaSource;
}
