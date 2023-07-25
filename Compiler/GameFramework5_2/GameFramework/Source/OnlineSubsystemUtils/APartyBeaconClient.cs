#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PartyBeaconClient.h")]
///<summary>A beacon client used for making reservations with an existing game session</summary>
public partial class APartyBeaconClient : AOnlineBeaconClient {
// PartyBeaconClient
	public void ClientReservationResponse(EPartyReservationResult ReservationResponse) {}
	public void ClientCancelReservationResponse(EPartyReservationResult ReservationResponse) {}
	public void ClientSendReservationUpdates(int NumRemainingReservations) {}
	public void ClientSendReservationFull() {}
	public string DestSessionId;
	public FPartyReservation PendingReservation;
	public EClientRequestType RequestType;
	public bool bPendingReservationSent;
	public bool bCancelReservation;
	public void ServerReservationRequest(string SessionId,FPartyReservation Reservation) {}
	public void ServerUpdateReservationRequest(string SessionId,FPartyReservation ReservationUpdate) {}
	public void ServerAddOrUpdateReservationRequest(string SessionId,FPartyReservation Reservation) {}
	public void ServerRemoveMemberFromReservationRequest(string SessionId,FPartyReservation ReservationUpdate) {}
	public void ServerCancelReservationRequest(FUniqueNetIdRepl PartyLeader) {}
}
