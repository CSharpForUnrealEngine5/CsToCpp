namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chat/SocialGroupChannel.h")]
public partial class USocialGroupChannel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SocialUser</summary>
	public USocialUser SocialUser;
	///<summary>GroupId</summary>
	public FUniqueNetIdRepl GroupId;
	///<summary>DisplayName</summary>
	public FText DisplayName;
	///<summary>Members</summary>
	public TArray<USocialUser> Members;
}
