namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles the many pieces of data passed into Client Receive</summary>
[CppInclude("GameFramework/LocalMessage.h")]
public partial struct FClientReceiveData {
	public APlayerController LocalPC;
	public FName MessageType;
	public int MessageIndex;
	public string MessageString;
	public APlayerState RelatedPlayerState_1;
	public APlayerState RelatedPlayerState_2;
	public UObject OptionalObject;
}
