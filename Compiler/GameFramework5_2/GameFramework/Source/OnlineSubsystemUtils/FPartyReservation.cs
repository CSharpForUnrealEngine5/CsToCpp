#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PartyBeaconState.h")]
///<summary>A whole party reservation</summary>
public partial struct FPartyReservation {
// PartyReservation
	public int TeamNum;
	public FUniqueNetIdRepl PartyLeader;
	public TArray<FPlayerReservation> PartyMembers;
	public TArray<FPlayerReservation> RemovedPartyMembers;
}
