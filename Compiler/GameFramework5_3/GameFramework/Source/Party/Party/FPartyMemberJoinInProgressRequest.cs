namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Join in progress request. Represents a request from a local party member to a remote party member to acquire a reservation for the session the remote party member is in.</summary>
[CppInclude("Party/PartyMember.h")]
public partial struct FPartyMemberJoinInProgressRequest {
	public FUniqueNetIdRepl Target;
	public long Time;
}
