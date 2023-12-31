namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct used to replicate data about the state of a single party member to all members.</summary>
[CppInclude("Party/PartyMember.h")]
public partial struct FPartyMemberRepData {
	public FPartyMemberPlatformData PlatformData;
	public ECrossplayPreference CrossplayPreference;
	public string JoinMethod;
	public FPartyMemberJoinInProgressData JoinInProgressData;
}
