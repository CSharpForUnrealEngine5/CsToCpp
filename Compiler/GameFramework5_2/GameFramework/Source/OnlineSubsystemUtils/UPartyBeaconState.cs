#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PartyBeaconState.h")]
///<summary>A beacon host used for taking reservations for an existing game session</summary>
public partial class UPartyBeaconState : UObject {
// PartyBeaconState
	public string SessionName;
	public int NumConsumedReservations;
	public int MaxReservations;
	public int NumTeams;
	public int NumPlayersPerTeam;
	public string TeamAssignmentMethod;
	public int ReservedHostTeamNum;
	public int ForceTeamNum;
	public bool bRestrictCrossConsole;
	public TArray<string> PlatformCrossplayRestrictions;
	public TArray<FPartyBeaconCrossplayPlatformMapping> PlatformTypeMapping;
	public bool bEnableRemovalRequests;
	public TArray<FPartyReservation> Reservations;
}
