namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyTypes.h")]
public partial struct FPartyPrivacySettings {
	public EPartyType PartyType;
	public EPartyInviteRestriction PartyInviteRestriction;
	public bool bOnlyLeaderFriendsCanJoin;
}
