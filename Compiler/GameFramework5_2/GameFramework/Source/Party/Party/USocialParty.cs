#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/SocialParty.h")]
///<summary>Party game state that contains all information relevant to the communication within a party</summary>
public partial class USocialParty : UObject {
// SocialParty
	public UClass ReservationBeaconClientClass;
	public UClass SpectatorBeaconClientClass;
	public FUniqueNetIdRepl OwningLocalUserId;
	public FUniqueNetIdRepl CurrentLeaderId;
	public TMap<FUniqueNetIdRepl,UPartyMember> PartyMembersById;
	public bool bEnableAutomaticPartyRejoin;
	public double PlatformUserInviteCooldown;
	public double PrimaryUserInviteCooldown;
	public TWeakObjectPtr<APartyBeaconClient> ReservationBeaconClient;
	public TWeakObjectPtr<ASpectatorBeaconClient> SpectatorBeaconClient;
	public float JoinInProgressTimerRate;
	public int JoinInProgressRequestTimeout;
	public int JoinInProgressResponseTimeout;
}
