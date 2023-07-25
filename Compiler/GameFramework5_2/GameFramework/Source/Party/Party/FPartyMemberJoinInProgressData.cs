#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyMember.h")]
///<summary>Join in progress data. Holds the current request and any responses. Requests and responses are expected to be cleared in a short amount of time. Combined into one field to reduce field count.</summary>
public partial struct FPartyMemberJoinInProgressData {
// PartyMemberJoinInProgressData
	public FPartyMemberJoinInProgressRequest Request;
	public TArray<FPartyMemberJoinInProgressResponse> Responses;
}
