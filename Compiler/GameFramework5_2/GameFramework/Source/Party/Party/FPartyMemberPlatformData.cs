#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyMember.h")]
///<summary>Platform data fields for party replication</summary>
public partial struct FPartyMemberPlatformData {
// PartyMemberPlatformData
	public FUserPlatform Platform;
	public FUniqueNetIdRepl UniqueId;
	public string SessionId;
}
