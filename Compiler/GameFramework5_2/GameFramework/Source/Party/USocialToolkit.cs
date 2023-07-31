#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the full suite of social functionality available to a given LocalPlayer</summary>
[CppInclude("SocialToolkit.h")]
public partial class USocialToolkit : UObject {
	///<summary>LocalUser</summary>
	public USocialUser LocalUser;
	///<summary>AllUsers</summary>
	public TArray<USocialUser> AllUsers;
	///<summary>LocalPlayerOwner</summary>
	public TWeakObjectPtr<ULocalPlayer> LocalPlayerOwner;
	///<summary>SocialChatManager</summary>
	public USocialChatManager SocialChatManager;
}
