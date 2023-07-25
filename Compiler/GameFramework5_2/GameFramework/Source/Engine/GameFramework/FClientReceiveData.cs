#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/LocalMessage.h")]
///<summary>Handles the many pieces of data passed into Client Receive</summary>
public partial struct FClientReceiveData {
// ClientReceiveData
	public APlayerController LocalPC;
	public string MessageType;
	public int MessageIndex;
	public string MessageString;
	public APlayerState RelatedPlayerState_1;
	public APlayerState RelatedPlayerState_2;
	public UObject OptionalObject;
}
