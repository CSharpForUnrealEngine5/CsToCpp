namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon host used for taking reservations for an existing game session</summary>
[CppInclude("PartyBeaconState.h")]
public partial class UPartyBeaconState : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Session tied to the beacon</summary>
	public string SessionName;
	///<summary>Number of currently consumed reservations</summary>
	public int NumConsumedReservations;
	///<summary>Maximum allowed reservations</summary>
	public int MaxReservations;
	///<summary>Number of teams in the game</summary>
	public int NumTeams;
	///<summary>Number of players on each team for balancing</summary>
	public int NumPlayersPerTeam;
	///<summary>Team assignment method</summary>
	public string TeamAssignmentMethod;
	///<summary>Team that the host has been assigned to</summary>
	public int ReservedHostTeamNum;
	///<summary>Team that everyone is forced to in single team games</summary>
	public int ForceTeamNum;
	///<summary>Are multiple consoles types allowed to play together</summary>
	public bool bRestrictCrossConsole;
	///<summary>Platform crossplay restrictions.  Expected in the format &quot;Plat1=Plat2,Plat3&quot; to indicate Plat1 is considered crossplay with Plat2 and Plat3</summary>
	public TArray<string> PlatformCrossplayRestrictions;
	///<summary>PlatformTypeMapping</summary>
	public TArray<FPartyBeaconCrossplayPlatformMapping> PlatformTypeMapping;
	///<summary>Process requests from clients to remove players from beacon</summary>
	public bool bEnableRemovalRequests;
	///<summary>Current reservations in the system</summary>
	public TArray<FPartyReservation> Reservations;
}
