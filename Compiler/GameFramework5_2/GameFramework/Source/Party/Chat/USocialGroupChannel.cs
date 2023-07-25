#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chat/SocialGroupChannel.h")]
public partial class USocialGroupChannel : UObject {
// SocialGroupChannel
	public USocialUser SocialUser;
	public FUniqueNetIdRepl GroupId;
	public string DisplayName;
	public TArray<USocialUser> Members;
}
