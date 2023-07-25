#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SocialSettings.h")]
///<summary>Config-driven settings object for the social framework.</summary>
public partial class USocialSettings : UObject {
// SocialSettings
	public TArray<string> OssNamesWithEnvironmentIdPrefix;
	public int DefaultMaxPartySize;
	public bool bPreferPlatformInvites;
	public bool bMustSendPrimaryInvites;
	public bool bLeavePartyOnDisconnect;
	public bool bSetDesiredPrivacyOnLocalPlayerBecomesLeader;
	public float UserListAutoUpdateRate;
	public int MinNicknameLength;
	public int MaxNicknameLength;
	public TArray<FSocialPlatformDescription> SocialPlatformDescriptions;
	public TArray<string> SonyOSSNames;
}
