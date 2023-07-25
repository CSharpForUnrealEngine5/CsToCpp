#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PartyBeaconState.h")]
///<summary>The result code that will be returned during party reservation</summary>
public enum EPartyReservationResult {
	NoResult=0,
	RequestPending=1,
	GeneralError=2,
	PartyLimitReached=3,
	IncorrectPlayerCount=4,
	RequestTimedOut=5,
	ReservationDuplicate=6,
	ReservationNotFound=7,
	ReservationAccepted=8,
	ReservationDenied=9,
	ReservationDenied_CrossPlayRestriction=10,
	ReservationDenied_Banned=11,
	ReservationRequestCanceled=12,
	ReservationInvalid=13,
	BadSessionId=14,
	ReservationDenied_ContainsExistingPlayers=15,
}
