#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpectatorBeaconClient.h")]
///<summary>A beacon client used for making reservations with an existing game session</summary>
public partial class ASpectatorBeaconClient : AOnlineBeaconClient {
// SpectatorBeaconClient
	public  void ClientReservationResponse(ESpectatorReservationResult ReservationResponse) {}
	public  void ClientCancelReservationResponse(ESpectatorReservationResult ReservationResponse) {}
	public  void ClientSendReservationUpdates(int NumRemainingReservations) {}
	public  void ClientSendReservationFull() {}
	public string DestSessionId;
	public FSpectatorReservation PendingReservation;
	public ESpectatorClientRequestType RequestType;
	public bool bPendingReservationSent;
	public bool bCancelReservation;
	public  void ServerReservationRequest(string SessionId,FSpectatorReservation Reservation) {}
	public  void ServerCancelReservationRequest(FUniqueNetIdRepl Spectator) {}
}
