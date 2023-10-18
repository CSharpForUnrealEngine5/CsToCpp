namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A blueprint class representing a Pixel Streaming Signalling connection. Used to communicate with the signalling server and</summary>
[CppInclude("PixelStreamingSignallingComponent.h")]
public partial class UPixelStreamingSignallingComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Attempt to connect to a specified signalling server.</summary>
	public void Connect(string Url) {}
	///<summary>Disconnect from the signalling server. No action if no connection exists.</summary>
	public void Disconnect() {}
	///<summary>Send a subscribe message to the signalling server to subscribe to a specific streamer.</summary>
	public void Subscribe(string StreamerId) {}
	///<summary>Send an unsubscribe message to the signalling server to unsubscribe from a streamer.</summary>
	public void Unsubscribe() {}
	///<summary>Send an offer created from a Peer Connection to the signalling server.</summary>
	public void SendOffer(FPixelStreamingSessionDescriptionWrapper Offer) {}
	///<summary>Send an answer created from a Peer Connection to the signalling server.</summary>
	public void SendAnswer(FPixelStreamingSessionDescriptionWrapper Answer) {}
	///<summary>Send an Ice Candidate to the signalling server that is generated from a Peer Connection.</summary>
	public void SendIceCandidate(FPixelStreamingIceCandidateWrapper CandidateWrapper) {}
	///<summary>Fired when the signalling connection is successfully established.</summary>
	public FPixelStreamingSignallingComponentConnected OnConnected;
	///<summary>Fired if the connection failed or an error occurs during the connection. If this is fired at any point the connection should be considered closed.</summary>
	public FPixelStreamingSignallingComponentConnectionError OnConnectionError;
	///<summary>Fired when the connection successfully closes.</summary>
	public FPixelStreamingSignallingComponentDisconnected OnDisconnected;
	///<summary>Fired when the connection receives a config message from the server. This is the earliest place where the peer connection can be initialized.</summary>
	public FPixelStreamingSignallingComponentConfig OnConfig;
	///<summary>Fired when the connection receives an offer from the server. This means there is media being offered up to this connection. Forward to the peer connection.</summary>
	public FPixelStreamingSignallingComponentOffer OnOffer;
	///<summary>Fired when the connection receives an answer from the server. The streamer is answering a previously sent offer by us. Forward to the peer connection.</summary>
	public FPixelStreamingSignallingComponentAnswer OnAnswer;
	///<summary>Fired when the server sends through an ice candidate. Forward this information on to the peer connection.</summary>
	public FPixelStreamingSignallingComponentIceCandidate OnIceCandidate;
	///<summary>If this media source is set we will use its supplied URL instead of the Url parameter on the connect call.</summary>
	public UStreamMediaSource MediaSource;
}
