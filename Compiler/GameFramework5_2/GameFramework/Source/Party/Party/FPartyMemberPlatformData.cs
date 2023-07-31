#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Platform data fields for party replication</summary>
[CppInclude("Party/PartyMember.h")]
public partial struct FPartyMemberPlatformData {
	public FUserPlatform Platform;
	public FUniqueNetIdRepl UniqueId;
	public string SessionId;
}
