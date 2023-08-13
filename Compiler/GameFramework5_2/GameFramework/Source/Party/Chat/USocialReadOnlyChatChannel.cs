namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A strawman chat channel that relies exclusively on other channels messages for content, does not support sending messages</summary>
[CppInclude("Chat/SocialReadOnlyChatChannel.h")]
public partial class USocialReadOnlyChatChannel : USocialChatChannel {
	public static UClass StaticClass() {return default;}
}
