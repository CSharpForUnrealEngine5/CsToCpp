#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SocialToolkit.h")]
///<summary>Represents the full suite of social functionality available to a given LocalPlayer</summary>
public partial class USocialToolkit : UObject {
// SocialToolkit
	public USocialUser LocalUser;
	public TArray<USocialUser> AllUsers;
	public TWeakObjectPtr<ULocalPlayer> LocalPlayerOwner;
	public USocialChatManager SocialChatManager;
}
