namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct used to replicate data about the state of the party to all members.</summary>
[CppInclude("Party/SocialParty.h")]
public partial struct FPartyRepData {
	public FPartyPrivacySettings PrivacySettings;
	public TArray<FPartyPlatformSessionInfo> PlatformSessions;
}
