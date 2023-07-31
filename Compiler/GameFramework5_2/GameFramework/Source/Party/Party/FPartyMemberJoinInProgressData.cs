#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Join in progress data. Holds the current request and any responses. Requests and responses are expected to be cleared in a short amount of time. Combined into one field to reduce field count.</summary>
[CppInclude("Party/PartyMember.h")]
public partial struct FPartyMemberJoinInProgressData {
	public FPartyMemberJoinInProgressRequest Request;
	public TArray<FPartyMemberJoinInProgressResponse> Responses;
}
