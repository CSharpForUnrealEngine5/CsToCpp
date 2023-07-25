#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chat/SocialPrivateMessageChannel.h")]
///<summary>A modified version of a chat room that only contains two participants - the current user and a private recipient of their messages.</summary>
public partial class USocialPrivateMessageChannel : USocialChatChannel {
// SocialPrivateMessageChannel
	public USocialUser TargetUser;
}
