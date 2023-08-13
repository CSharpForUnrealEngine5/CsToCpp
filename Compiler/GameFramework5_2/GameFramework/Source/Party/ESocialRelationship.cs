namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SocialTypes.h")]
///<summary>Per-OSS relationship types</summary>
public enum ESocialRelationship {
	Any=0,
	FriendInviteReceived=1,
	FriendInviteSent=2,
	PartyInvite=3,
	Friend=4,
	BlockedPlayer=5,
	SuggestedFriend=6,
	RecentPlayer=7,
	JoinRequest=8,
}
