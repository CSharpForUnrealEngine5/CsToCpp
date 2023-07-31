#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Online/CoreOnline.h")]
public partial struct FJoinabilitySettings {
	public string SessionName;
	public bool bPublicSearchable;
	public bool bAllowInvites;
	public bool bJoinViaPresence;
	public bool bJoinViaPresenceFriendsOnly;
	public int MaxPlayers;
	public int MaxPartySize;
}
