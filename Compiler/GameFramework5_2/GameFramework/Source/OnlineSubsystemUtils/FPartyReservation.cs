namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A whole party reservation</summary>
[CppInclude("PartyBeaconState.h")]
public partial struct FPartyReservation {
	public int TeamNum;
	public FUniqueNetIdRepl PartyLeader;
	public TArray<FPlayerReservation> PartyMembers;
	public TArray<FPlayerReservation> RemovedPartyMembers;
}
