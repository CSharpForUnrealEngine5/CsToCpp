#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The chat manager is a fully passive construct that watches for creation of chat rooms and message activity therein</summary>
[CppInclude("Chat/SocialChatManager.h")]
public partial class USocialChatManager : UObject {
	///<summary>DirectChannelsByTargetUser</summary>
	public TMap<TWeakObjectPtr<USocialUser>,USocialPrivateMessageChannel> DirectChannelsByTargetUser;
	///<summary>ChatRoomsById</summary>
	public TMap<string,USocialChatRoom> ChatRoomsById;
	///<summary>ReadOnlyChannelsByDisplayName</summary>
	public TMap<string,USocialReadOnlyChatChannel> ReadOnlyChannelsByDisplayName;
	///<summary>bEnableChatSlashCommands</summary>
	public bool bEnableChatSlashCommands;
	///<summary>GroupChannels</summary>
	public TMap<FUniqueNetIdRepl,USocialGroupChannel> GroupChannels;
}
