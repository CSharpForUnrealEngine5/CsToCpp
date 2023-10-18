namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class for maintaining a single chat room at the game level</summary>
[CppInclude("Chatroom.h")]
public partial class UChatroom : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Current chat room associated with this object (FString so UPROPERTY works)</summary>
	public string CurrentChatRoomId;
	///<summary>Max number of retries before giving up on chat</summary>
	public int MaxChatRoomRetries;
	///<summary>Current number of retries on a chat room</summary>
	public int NumChatRoomRetries;
}
