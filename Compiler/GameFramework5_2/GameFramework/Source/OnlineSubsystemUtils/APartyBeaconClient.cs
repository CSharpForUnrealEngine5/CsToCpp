#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon client used for making reservations with an existing game session</summary>
[CppInclude("PartyBeaconClient.h")]
public partial class APartyBeaconClient : AOnlineBeaconClient {
	///<summary>Response from the host session after making a reservation request</summary>
	public  void ClientReservationResponse(EPartyReservationResult ReservationResponse) {}
	///<summary>Response from the host session after making a cancellation request</summary>
	public  void ClientCancelReservationResponse(EPartyReservationResult ReservationResponse) {}
	///<summary>Response from the host session that the reservation count has changed</summary>
	public  void ClientSendReservationUpdates(int NumRemainingReservations) {}
	///<summary>Response from the host session that the reservation is full</summary>
	public  void ClientSendReservationFull() {}
	///<summary>Session Id of the destination host</summary>
	public string DestSessionId;
	///<summary>Pending reservation that will be sent upon connection with the intended host</summary>
	public FPartyReservation PendingReservation;
	///<summary>Type of request currently being handled by this client beacon</summary>
	public EClientRequestType RequestType;
	///<summary>Has the reservation request been delivered</summary>
	public bool bPendingReservationSent;
	///<summary>Has the reservation request been canceled</summary>
	public bool bCancelReservation;
	///<summary>Tell the server about the reservation request being made</summary>
	public  void ServerReservationRequest(string SessionId,FPartyReservation Reservation) {}
	///<summary>Tell the server about the reservation update request being made</summary>
	public  void ServerUpdateReservationRequest(string SessionId,FPartyReservation ReservationUpdate) {}
	///<summary>Tell the server about the reservation add or update request being made</summary>
	public  void ServerAddOrUpdateReservationRequest(string SessionId,FPartyReservation Reservation) {}
	///<summary>Tell the server that we are removing members from our reservation</summary>
	public  void ServerRemoveMemberFromReservationRequest(string SessionId,FPartyReservation ReservationUpdate) {}
	///<summary>Tell the server to cancel a pending or existing reservation</summary>
	public  void ServerCancelReservationRequest(FUniqueNetIdRepl PartyLeader) {}
}
