namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Join in progress response. Represents a response from a local party member to a remote party member that requested to join in progress.</summary>
[CppInclude("Party/PartyMember.h")]
public partial struct FPartyMemberJoinInProgressResponse {
	public FUniqueNetIdRepl Requester;
	public long RequestTime;
	public long ResponseTime;
	public byte DenialReason;
}
