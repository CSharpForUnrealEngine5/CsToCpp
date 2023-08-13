namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Platform data fields for party replication</summary>
[CppInclude("Party/PartyMember.h")]
public partial struct FPartyMemberPlatformData {
	public FUserPlatform Platform;
	public FUniqueNetIdRepl UniqueId;
	public string SessionId;
}
