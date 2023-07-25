#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PartyBeaconClient.h")]
///<summary>Types of reservation requests that can be made by this beacon</summary>
public enum EClientRequestType {
	NonePending=0,
	ExistingSessionReservation=1,
	ReservationUpdate=2,
	EmptyServerReservation=3,
	Reconnect=4,
	Abandon=5,
	ReservationRemoveMembers=6,
	AddOrUpdateReservation=7,
}
