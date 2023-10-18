namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the full suite of social functionality available to a given LocalPlayer</summary>
[CppInclude("SocialToolkit.h")]
public partial class USocialToolkit : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LocalUser</summary>
	public USocialUser LocalUser;
	///<summary>AllUsers</summary>
	public TArray<USocialUser> AllUsers;
	///<summary>bRemoveInvalidatedUserFromMaps</summary>
	public bool bRemoveInvalidatedUserFromMaps;
	///<summary>LocalPlayerOwner</summary>
	public TWeakObjectPtr<ULocalPlayer> LocalPlayerOwner;
	///<summary>SocialChatManager</summary>
	public USocialChatManager SocialChatManager;
}
