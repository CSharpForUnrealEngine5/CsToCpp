namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon client used for making reservations with an existing game session</summary>
[CppInclude("SpectatorBeaconClient.h")]
public partial class ASpectatorBeaconClient : AOnlineBeaconClient {
	public static UClass StaticClass() {return default;}
	///<summary>Response from the host session after making a reservation request</summary>
	public virtual void ClientReservationResponse(ESpectatorReservationResult ReservationResponse) {}
	///<summary>Response from the host session after making a cancellation request</summary>
	public virtual void ClientCancelReservationResponse(ESpectatorReservationResult ReservationResponse) {}
	///<summary>Response from the host session that the reservation count has changed</summary>
	public virtual void ClientSendReservationUpdates(int NumRemainingReservations) {}
	///<summary>Response from the host session that the reservation is full</summary>
	public virtual void ClientSendReservationFull() {}
	///<summary>Session Id of the destination host</summary>
	public string DestSessionId;
	///<summary>Pending reservation that will be sent upon connection with the intended host</summary>
	public FSpectatorReservation PendingReservation;
	///<summary>Type of request currently being handled by this client beacon</summary>
	public ESpectatorClientRequestType RequestType;
	///<summary>Has the reservation request been delivered</summary>
	public bool bPendingReservationSent;
	///<summary>Has the reservation request been canceled</summary>
	public bool bCancelReservation;
	///<summary>Tell the server about the reservation request being made</summary>
	public virtual void ServerReservationRequest(string SessionId,FSpectatorReservation Reservation) {}
	///<summary>Tell the server to cancel a pending or existing reservation</summary>
	public virtual void ServerCancelReservationRequest(FUniqueNetIdRepl Spectator) {}
}
