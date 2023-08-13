namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Config-driven settings object for the social framework.</summary>
[CppInclude("SocialSettings.h")]
public partial class USocialSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The specific OSS&#39; that have their IDs stored with an additional prefix for the environment to which they pertain.</summary>
	public TArray<string> OssNamesWithEnvironmentIdPrefix;
	///<summary>How many players are in a party by default</summary>
	public int DefaultMaxPartySize;
	///<summary>If true, prioritize the platform&#39;s social system over the publisher&#39;s</summary>
	public bool bPreferPlatformInvites;
	///<summary>If true, always send invites using the publisher&#39;s system even if already sent via a platform system</summary>
	public bool bMustSendPrimaryInvites;
	///<summary>Should we leave a party when it enters the disconnected state?</summary>
	public bool bLeavePartyOnDisconnect;
	///<summary>How often the user list will update in seconds</summary>
	public bool bSetDesiredPrivacyOnLocalPlayerBecomesLeader;
	///<summary>UserListAutoUpdateRate</summary>
	public float UserListAutoUpdateRate;
	///<summary>Shortest possible player nickname</summary>
	public int MinNicknameLength;
	///<summary>Longest possible player nickname</summary>
	public int MaxNicknameLength;
	///<summary>SocialPlatformDescriptions</summary>
	public TArray<FSocialPlatformDescription> SocialPlatformDescriptions;
	///<summary>SonyOSSNames</summary>
	public TArray<string> SonyOSSNames;
}
