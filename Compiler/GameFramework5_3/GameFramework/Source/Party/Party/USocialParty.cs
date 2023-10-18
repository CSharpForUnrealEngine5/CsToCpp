namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Party game state that contains all information relevant to the communication within a party</summary>
[CppInclude("Party/SocialParty.h")]
public partial class USocialParty : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reservation beacon class for getting server approval for new party members while in a game</summary>
	public UClass ReservationBeaconClientClass;
	///<summary>Spectator beacon class for getting server approval for new spectators while in a game</summary>
	public UClass SpectatorBeaconClientClass;
	///<summary>OwningLocalUserId</summary>
	public FUniqueNetIdRepl OwningLocalUserId;
	///<summary>Tracked explicitly so we know which player was demoted whenever the leader changes</summary>
	public FUniqueNetIdRepl CurrentLeaderId;
	///<summary>PartyMembersById</summary>
	public TMap<FUniqueNetIdRepl,UPartyMember> PartyMembersById;
	///<summary>bEnableAutomaticPartyRejoin</summary>
	public bool bEnableAutomaticPartyRejoin;
	///<summary>PlatformUserInviteCooldown</summary>
	public double PlatformUserInviteCooldown;
	///<summary>PrimaryUserInviteCooldown</summary>
	public double PrimaryUserInviteCooldown;
	///<summary>Reservation beacon client instance while getting approval for new party members</summary>
	public TWeakObjectPtr<APartyBeaconClient> ReservationBeaconClient;
	///<summary>Spectator beacon client instance while getting approval for spectator</summary>
	public TWeakObjectPtr<ASpectatorBeaconClient> SpectatorBeaconClient;
	///<summary>How often the timer should check in seconds for stale data when running.</summary>
	public float JoinInProgressTimerRate;
	///<summary>How long in seconds before join in progress requests timeout and are cleared from member data.</summary>
	public int JoinInProgressRequestTimeout;
	///<summary>How long in seconds before join in progress responses are cleared from member data.</summary>
	public int JoinInProgressResponseTimeout;
}
