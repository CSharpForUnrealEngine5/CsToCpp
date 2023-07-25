#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chatroom.h")]
///<summary>Helper class for maintaining a single chat room at the game level</summary>
public partial class UChatroom : UObject {
// Chatroom
	public string CurrentChatRoomId;
	public int MaxChatRoomRetries;
	public int NumChatRoomRetries;
}
