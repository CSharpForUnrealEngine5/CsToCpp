#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A modified version of a chat room that only contains two participants - the current user and a private recipient of their messages.</summary>
[CppInclude("Chat/SocialPrivateMessageChannel.h")]
public partial class USocialPrivateMessageChannel : USocialChatChannel {
	public static UClass StaticClass() {return default;}
	///<summary>The recipient of the current user&#39;s messages</summary>
	public USocialUser TargetUser;
}
