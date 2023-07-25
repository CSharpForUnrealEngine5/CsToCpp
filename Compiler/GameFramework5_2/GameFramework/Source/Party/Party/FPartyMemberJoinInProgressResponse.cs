#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyMember.h")]
///<summary>Join in progress response. Represents a response from a local party member to a remote party member that requested to join in progress.</summary>
public partial struct FPartyMemberJoinInProgressResponse {
// PartyMemberJoinInProgressResponse
	public FUniqueNetIdRepl Requester;
	public long RequestTime;
	public long ResponseTime;
	public byte DenialReason;
}
