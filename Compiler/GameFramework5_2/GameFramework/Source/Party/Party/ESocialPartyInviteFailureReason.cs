#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyTypes.h")]
public enum ESocialPartyInviteFailureReason {
	Success=0,
	NotOnline=1,
	NotAcceptingMembers=2,
	NotFriends=3,
	AlreadyInParty=4,
	OssValidationFailed=5,
	PlatformInviteFailed=6,
	PartyInviteFailed=7,
	InviteRateLimitExceeded=8,
}
