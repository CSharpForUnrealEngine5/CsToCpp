#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyTypes.h")]
public partial struct FPartyPrivacySettings {
	public EPartyType PartyType;
	public EPartyInviteRestriction PartyInviteRestriction;
	public bool bOnlyLeaderFriendsCanJoin;
}
