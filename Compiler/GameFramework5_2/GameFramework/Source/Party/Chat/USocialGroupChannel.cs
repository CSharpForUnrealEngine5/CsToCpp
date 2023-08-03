#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	public string DisplayName;
	///<summary>Members</summary>
	public TArray<USocialUser> Members;
}
