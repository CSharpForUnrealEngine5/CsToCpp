#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/PartyMember.h")]
///<summary>Base struct used to replicate data about the state of a single party member to all members.</summary>
public partial struct FPartyMemberRepData {
// PartyMemberRepData
	public FPartyMemberPlatformData PlatformData;
	public ECrossplayPreference CrossplayPreference;
	public string JoinMethod;
	public FPartyMemberJoinInProgressData JoinInProgressData;
}
