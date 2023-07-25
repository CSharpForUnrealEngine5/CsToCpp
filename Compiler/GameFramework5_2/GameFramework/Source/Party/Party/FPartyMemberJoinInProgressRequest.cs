#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyMember.h")]
///<summary>Join in progress request. Represents a request from a local party member to a remote party member to acquire a reservation for the session the remote party member is in.</summary>
public partial struct FPartyMemberJoinInProgressRequest {
// PartyMemberJoinInProgressRequest
	public FUniqueNetIdRepl Target;
	public long Time;
}
