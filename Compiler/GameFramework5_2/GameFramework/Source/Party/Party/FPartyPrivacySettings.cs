#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyTypes.h")]
public partial struct FPartyPrivacySettings {
// PartyPrivacySettings
	public EPartyType PartyType;
	public EPartyInviteRestriction PartyInviteRestriction;
	public bool bOnlyLeaderFriendsCanJoin;
}
