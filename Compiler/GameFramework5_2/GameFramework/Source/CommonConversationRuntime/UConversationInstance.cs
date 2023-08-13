namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An active conversation between one or more participants</summary>
[CppInclude("ConversationInstance.h")]
public partial class UConversationInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Participants</summary>
	public FConversationParticipants Participants;
}
