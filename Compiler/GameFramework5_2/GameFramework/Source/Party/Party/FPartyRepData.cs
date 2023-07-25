#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Party/SocialParty.h")]
///<summary>Base struct used to replicate data about the state of the party to all members.</summary>
public partial struct FPartyRepData {
// PartyRepData
	public FPartyPrivacySettings PrivacySettings;
	public TArray<FPartyPlatformSessionInfo> PlatformSessions;
}
